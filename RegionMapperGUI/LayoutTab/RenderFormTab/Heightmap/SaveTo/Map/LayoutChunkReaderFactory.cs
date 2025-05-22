using System;
using WorldEditor;
using NbtEditor;

namespace RegionMapperGUI {
    public class LayoutChunkReaderFactory : ChunkReaderFactory {
        public RegionAreaLayout Layout { get; set; }

        public LayoutChunkReaderFactory(RegionAreaLayout layout) {
            Layout = layout; 
        }

        protected override IChunkReader<(CompoundTag, ChunkLoadSettings)> CreateFlattenedReader((CompoundTag, ChunkLoadSettings) parameter) {
            return new FlattenedChunkReader() { ChunkConfigurationFactory = new LayoutChunkConfigurationFactory() { Layout = Layout } };
        }
    }
}
