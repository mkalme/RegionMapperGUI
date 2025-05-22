using System;
using System.Windows.Forms;
using System.IO;
using RegionMapper;

namespace RegionMapperGUI {
    public class BrowseLayoutProvider : ILayoutObjectProvider<HeightmapLayout> {
        public ILayoutObjectProvider<HeightmapBrowseLayout> LayoutProvider { get; set; }

        public AssetLayout AssetLayout { get; set; }

        public BrowseLayoutProvider() { 
            LayoutProvider = new InteractiveLayoutProvider<HeightmapBrowseLayout>(new HeightmapBrowseLayout());
        }

        public Control CreateControl() {
            return LayoutProvider.CreateControl();
        }
        public HeightmapLayout CreateObject() {
            HeightmapBrowseLayout layout;
            
            try {
                layout = LayoutProvider.CreateObject();
            } catch {
                return null;
            }

            var elevationCacheController = new ElevationCacheController();
            var reader = new WorldMapperReader(layout.SectorSize, elevationCacheController, AssetLayout.MapperAssetManager);

            Stream fileStream = File.Open(layout.Path, FileMode.Open);
            reader.Open(fileStream);

            return new HeightmapLayout() {
                MapReader = reader,
                ElevationCacheController = elevationCacheController,
                Stream = fileStream
            };
        }
    }
}
