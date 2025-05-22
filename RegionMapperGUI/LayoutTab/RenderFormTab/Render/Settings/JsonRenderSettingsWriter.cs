using System;
using System.IO;
using Newtonsoft.Json.Linq;

namespace RegionMapperGUI {
    public class JsonRenderSettingsWriter : IRenderSettingsWriter {
        public void Write(string file, RenderLayout layout) {
            using (StreamWriter newFile = File.CreateText(file)) {
                JObject jObject = JObject.FromObject(layout);

                newFile.Write(jObject.ToString());
            }
        }
    }
}
