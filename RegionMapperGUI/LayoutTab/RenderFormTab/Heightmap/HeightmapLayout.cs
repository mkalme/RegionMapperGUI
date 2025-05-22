using System;
using System.IO;
using Heightmap;
using RegionMapper;

namespace RegionMapperGUI {
    public class HeightmapLayout {
        public MapReader<ColumnChunkOutput> MapReader { get; set; }
        public IElevationCacheController ElevationCacheController { get; set; }
        public Stream Stream { get; set; }
    }
}
