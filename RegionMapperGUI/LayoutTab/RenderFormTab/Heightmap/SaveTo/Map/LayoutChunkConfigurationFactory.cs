using System;
using WorldEditor;

namespace RegionMapperGUI {
    public class LayoutChunkConfigurationFactory : IChunkConfigurationFactory {
        public RegionAreaLayout Layout { get; set; }

        public ChunkConfiguration CreateConfiguration(Chunk chunk) {
            return new ChunkConfiguration(Layout.MinY, 320);
        }
    }
}
