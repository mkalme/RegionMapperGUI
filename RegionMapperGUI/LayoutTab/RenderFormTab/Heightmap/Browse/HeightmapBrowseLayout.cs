using System;
using InteractiveGUI;

namespace RegionMapperGUI {
    public class HeightmapBrowseLayout {

        [Interactive("Heightmap file path"), BrowserInput(BrowseType.File, "Rendered heightmap file|*.brhf"), PathValidator(BrowseType.File)]
        public string Path { get; set; }

        [Interactive("Sector size")]
        public int SectorSize { get; set; } = 1024;
    }
}
