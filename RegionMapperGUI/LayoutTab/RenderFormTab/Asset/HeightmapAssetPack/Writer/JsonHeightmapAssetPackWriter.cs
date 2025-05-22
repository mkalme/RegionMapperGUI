using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json.Linq;

namespace RegionMapperGUI {
    public class JsonHeightmapAssetPackWriter : IHeightmapAssetPackWriter {
        public void WritePack(string file, IList<HeightmapAssetBlock> assetPack) {
            using (FileStream fileStream = File.OpenWrite(file))
            using (StreamWriter streamWriter = new StreamWriter(fileStream)) {
                streamWriter.Write(JObject.FromObject(new HeightmapAssetPack(assetPack)).ToString());
            }
        }
    }
}
