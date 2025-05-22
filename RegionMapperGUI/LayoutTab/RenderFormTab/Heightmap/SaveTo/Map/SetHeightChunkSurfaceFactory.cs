using System;
using WorldEditor;
using Heightmap;

namespace RegionMapperGUI {
    public class SetHeightChunkSurfaceFactory : IChunkSurfaceFactory<(Chunk, SectionSpan)> {
        public short Height { get; set; }

        public SetHeightChunkSurfaceFactory(short height) {
            Height = height;
        }

        public IChunkSurface CreateChunkSurface((Chunk, SectionSpan) parameter) {
            return new SetChunkSurface(Height);
        }
    }
}
