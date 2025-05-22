using System;
using System.Collections.Generic;
using AssetManagementSystem;
using Heightmap;
using WorldEditor;

namespace RegionMapperGUI {
    public class CustomHeightmapAssetManagerDeserializer : HeightmapAssetManagerDeserializer {
        public IDictionary<string, BlockCondition<HeightmapBlockType>> Blocks { get; set; }

        public CustomHeightmapAssetManagerDeserializer(string assetFolder) : base(assetFolder) {

        }

        protected override IAsset<IBlock, HeightmapBlockType> LoadHeightmapAsset(IEnumerable<string> files) {
            var deserializer = new CustomJbasHeightmapAssetDeserializer(files) {
                Blocks = Blocks
            };

            return deserializer.Deserialize();
        }
    }
}
