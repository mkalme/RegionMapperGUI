using System;
using System.Collections.Generic;

namespace RegionMapperGUI {
    public class HeightmapAssetPack {
        public IList<HeightmapAssetBlock> Blocks { get; set; }

        public HeightmapAssetPack(IList<HeightmapAssetBlock> assetPack) {
            Blocks = assetPack;
        }
    }
}
