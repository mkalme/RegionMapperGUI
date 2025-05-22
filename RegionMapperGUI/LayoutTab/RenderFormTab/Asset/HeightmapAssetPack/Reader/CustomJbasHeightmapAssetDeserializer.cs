using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using AssetManagementSystem;
using Heightmap;
using WorldEditor;
using Newtonsoft.Json.Linq;

namespace RegionMapperGUI {
    public class CustomJbasHeightmapAssetDeserializer : JbasHeightmapAssetDeserializer {
        public IDictionary<string, BlockCondition<HeightmapBlockType>> Blocks { get; set; } = new Dictionary<string, BlockCondition<HeightmapBlockType>>();

        public CustomJbasHeightmapAssetDeserializer(IEnumerable<string> files) : base(files) {
            Files = files.ToArray();
        }

        public override IAsset<IBlock, HeightmapBlockType> Deserialize() {
            for (int i = 0; i < Files.Length; i++) {
                string jsonString = File.ReadAllText(Files[i]);
                var rootObject = JObject.Parse(jsonString);

                var blockType = GetBlockType((string)rootObject["Type"]);

                var jbas = new JbasDeserializer<BlockCondition<HeightmapBlockType>>(jsonString, Blocks);
                jbas.Deserializer = new JbasConditionDeserializer<HeightmapBlockType>(blockType, HeightmapBlockType.None);

                jbas.Deserialize();
            }

            return new BlockConditionAsset<HeightmapBlockType>(Blocks) { DefaultValue = HeightmapBlockType.None };
        }
    }
}
