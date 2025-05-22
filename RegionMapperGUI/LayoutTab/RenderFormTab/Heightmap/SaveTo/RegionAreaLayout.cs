using System;
using System.Drawing;
using InteractiveGUI;

namespace RegionMapperGUI {
    public class RegionAreaLayout {
        [Interactive("Region folder"), BrowserInput(BrowseType.Folder), PathValidator(BrowseType.Folder)]
        public string Path { get; set; } = "";

        [Interactive("Bottom left corner (x, z)")]
        public Point BottomLeftCorner { get; set; } = new Point(0, 0);

        [Interactive("Top right corner (x, z)")]
        public Point TopRightCorner { get; set; } = new Point(0, 0);

        [Interactive("Minimum Y level")]
        public short MinY { get; set; } = -64;

        [Interactive("Heightmap configuration"), SetHeightInput]
        public HeightmapSettingsLayout HeightmapSettings { get; set; } = new HeightmapSettingsLayout();

        [Interactive("Sector size"), PropertyInput(ScaleType.Horizontal, "SectorSizeWrite", "SectorSizeRead")]
        public SectorSizeLayout SectorSize { get; set; } = new SectorSizeLayout();

        [Interactive("Save configuration"), HeightmapSaveInput]
        public HeightmapSaveToLayout DeletionSettings { get; set; } = new HeightmapSaveToLayout();
    }
}
