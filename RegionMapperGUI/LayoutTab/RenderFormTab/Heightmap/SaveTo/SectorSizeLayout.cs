using System;
using InteractiveGUI;

namespace RegionMapperGUI {
    public class SectorSizeLayout {
        
        [Interactive("Write")]
        public int SectorSizeWrite { get; set; } = 1024 * 10;
        
        [Interactive("Read")]
        public int SectorSizeRead { get; set; } = 1024;
    }
}
