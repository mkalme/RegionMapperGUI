using System;
using System.Collections.Generic;

namespace RegionMapperGUI {
    public interface IHeightmapAssetPackWriter {
        void WritePack(string file, IList<HeightmapAssetBlock> assetPack);
    }
}
