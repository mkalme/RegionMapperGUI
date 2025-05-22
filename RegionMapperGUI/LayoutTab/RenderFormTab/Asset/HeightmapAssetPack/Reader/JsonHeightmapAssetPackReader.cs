using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json.Linq;

namespace RegionMapperGUI {
    public class JsonHeightmapAssetPackReader : IHeightmapAssetPackReader {
        public IList<HeightmapAssetBlock> ReadPack(string file) {
            JObject jObject = JObject.Parse(File.ReadAllText(file));

            return jObject.ToObject<HeightmapAssetPack>().Blocks;
        }
    }
}
