using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using RegionMapper;
using Heightmap;
using WorldEditor;

namespace RegionMapperGUI {
    public class SaveToLayoutProvider : ILayoutObjectProvider<HeightmapLayout> {
        public ILayoutObjectProvider<RegionAreaLayout> LayoutProvider { get; set; }

        public AssetLayout AssetLayout { get; set; }

        private FileStream _fileStream;
        private string _file;

        public SaveToLayoutProvider() {
            LayoutProvider = new InteractiveLayoutProvider<RegionAreaLayout>(new RegionAreaLayout());
        }

        public Control CreateControl() {
            return LayoutProvider.CreateControl();
        }
        public HeightmapLayout CreateObject() {
            RegionAreaLayout layout;

            try {
                layout = LayoutProvider.CreateObject();
            } catch {
                return null;
            }

            string path = layout.DeletionSettings.Path;
            if (layout.DeletionSettings.DeleteAfterRender) {
                path = $"{Path.GetTempPath()}\\{Path.GetRandomFileName()}\\heightmap";
                Directory.CreateDirectory(Path.GetDirectoryName(path));
            }

            WriteMap(layout, path);

            var elevationCacheController = new ElevationCacheController();
            var reader = new WorldMapperReader(layout.SectorSize.SectorSizeRead, elevationCacheController, AssetLayout.MapperAssetManager);

            if (layout.DeletionSettings.DeleteAfterRender) {
                var sectorReader = new SectorMapReaderNotifty<ColumnChunkOutput>(reader.SectorReader);
                sectorReader.OnFinishedReading += OnFinish;
                reader.SectorReader = sectorReader;
            }

            FileStream fileStream = File.Open(path, FileMode.Open);
            reader.Open(fileStream);

            _fileStream = fileStream;
            _file = path;

            return new HeightmapLayout() {
                MapReader = reader,
                ElevationCacheController = elevationCacheController,
                Stream = fileStream
            };
        }

        private void WriteMap(RegionAreaLayout layout, string path) {
            WorldMapperWriter writer = new WorldMapperWriter(GetFiles(layout), AssetLayout.HeightmapAssetManager.Heightmap, AssetLayout.MapperAssetManager, layout.SectorSize.SectorSizeWrite);

            var chunkScanner = new ChunkScanner(AssetLayout.HeightmapAssetManager.Heightmap) {
                MinHeight = 16,
                ChunkSurfaceFactory = CreateChunkSurfaceFactory(layout)
            };

            writer.RegionReader = CreateRegionReader(layout);
            writer.LoadSettings = LoadSettingsSimpleFactory.CreateChunkLoadSettings();
            writer.SectorWriter = new SectorMapWriter<Chunk>() {
                ChunkWriter = new MapperChunkWriter(chunkScanner, AssetLayout.MapperAssetManager),
                SectorSize = layout.SectorSize.SectorSizeWrite,
                MapWriter = writer
            };

            using (FileStream stream = File.Create(path)) {
                writer.Scan(stream);
            }
        }
        private static IRegionReader<(string, ChunkLoadSettings)> CreateRegionReader(RegionAreaLayout layout) {
            return new RegionReader() {
                ChunkReaderFactory = new LayoutChunkReaderFactory(layout)
            };
        }
        private static IChunkSurfaceFactory<(Chunk, SectionSpan)> CreateChunkSurfaceFactory(RegionAreaLayout layout) {
            if (!layout.HeightmapSettings.SetHeightEnabled) return new ChunkSurfaceFactory();
            return new SetHeightChunkSurfaceFactory(layout.HeightmapSettings.MaxHeight);
        }

        private static string[] GetFiles(RegionAreaLayout layout) {
            List<string> files = new List<string>();
            
            for (int x = layout.BottomLeftCorner.X; x <= layout.TopRightCorner.X; x++) {
                for (int y = layout.BottomLeftCorner.Y; y <= layout.TopRightCorner.Y; y++) {
                    string fileName = $"{layout.Path}\\{Region.GetFileName(x, y)}";

                    if (File.Exists(fileName)) files.Add(fileName);
                }
            }

            return files.ToArray();
        }

        private void OnFinish(object sender, EventArgs e) {
            _fileStream.Close();
            File.Delete(_file);
        }
    }
}
