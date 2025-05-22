using System;
using System.IO;
using Newtonsoft.Json.Linq;

namespace RegionMapperGUI {
    public class JsonRenderSettingsReader : IRenderSettingsReader {
        public RenderLayout Read(string file) {
            JObject jObject = JObject.Parse(File.ReadAllText(file));

            return jObject.ToObject<RenderLayout>();
        }
    }
}
