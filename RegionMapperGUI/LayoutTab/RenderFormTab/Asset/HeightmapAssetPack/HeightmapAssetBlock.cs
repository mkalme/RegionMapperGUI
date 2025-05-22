using System;
using Heightmap;
using AssetManagementSystem;

namespace RegionMapperGUI {
    public class HeightmapAssetBlock {
        public BlockCondition<HeightmapBlockType> BlockCondition { get; set; }
        public HeightmapBlockType Type { get; set; }
        public bool Enabled { get; set; }
    }
}
