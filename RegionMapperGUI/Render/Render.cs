using System;
using System.Drawing;
using RegionMapper;

namespace RegionMapperGUI {
    public static class Render {
        public static readonly Color BackColor = Color.FromArgb(25, 25, 25);

        public static Image RenderMap(HeightmapLayout mapLayout, RenderLayout renderLayout) {
            WorldRenderer renderer = new WorldRenderer(mapLayout.MapReader.UpperRightCorner, mapLayout.MapReader.BottomLeftCorner) {
                ColumnPainter = CreateColumnPainter(renderLayout)
            };

            var elevationScanner = new ElevationMapReaderScanner(mapLayout.ElevationCacheController);

            double totalChunks = mapLayout.MapReader.SectorReader.LeftChunkCount;
            while (mapLayout.MapReader.ReadNext(out ColumnChunkOutput[] chunks)) {
                elevationScanner.Chunks = chunks;
                renderer.Chunks = chunks;

                renderer.ElevationMap = elevationScanner.ScanHeightmap();
                renderer.Render();

                Console.WriteLine($"Completed: {((totalChunks - mapLayout.MapReader.SectorReader.LeftChunkCount) / totalChunks * 100).ToString("N2").Replace(",", ".")}%");
            }

            mapLayout.Stream.Close();

            return renderer.Output;
        }

        private static IColumnPainter CreateColumnPainter(RenderLayout layout) {
            NonTransparentPainter nonTransparentPainter = new NonTransparentPainter(BackColor);
            SemiTransparentPainter semiTransparentPainter = new SemiTransparentPainter(BackColor, new DepthBlockspanReaderExtractor());

            SetBlockPainter(nonTransparentPainter.BlockPainter as NonTransparentBlockPainer, layout, layout.NonTransparentElevationPainter);
            SetBlockPainter(semiTransparentPainter.BlockPainter as SemiTransparentBlockPainer, layout, layout.SemiTransparentElevationPainter);

            return new ColumnPainterFacade(BackColor, nonTransparentPainter, semiTransparentPainter) {
                BackColor = BackColor,
            };
        }
        private static void SetBlockPainter(BlockPainter blockPainter, RenderLayout renderLayout, ElevationPainter elevationPainter) {
            blockPainter.AltitudePainter = new RegionMapper.AltitudePainter() {
                Increment = renderLayout.AltitudePainter.Increment,
                AverageY = renderLayout.AltitudePainter.AverageY,
                Min = renderLayout.AltitudePainter.Range.Min,
                Max = renderLayout.AltitudePainter.Range.Max
            };

            blockPainter.ElevationPainter = new RegionMapper.ElevationPainter(elevationPainter.MainIncrement, elevationPainter.SecondIncrement);

            blockPainter.LightPainter = new RegionMapper.LightPainter() {
                AmbientLight = renderLayout.LightPainter.AmbientLight,
                SunIntensity = renderLayout.LightPainter.SunIntensity
            };
        }
    }
}
