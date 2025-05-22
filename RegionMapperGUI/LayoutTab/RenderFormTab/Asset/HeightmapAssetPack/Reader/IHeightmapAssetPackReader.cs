using System;
using System.Collections.Generic;

namespace RegionMapperGUI {
    public interface IHeightmapAssetPackReader {
        IList<HeightmapAssetBlock> ReadPack(string file);
    }
}
