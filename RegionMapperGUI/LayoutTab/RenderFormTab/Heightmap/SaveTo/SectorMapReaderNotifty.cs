using System;
using System.IO;
using Heightmap;

namespace RegionMapperGUI {
    public class SectorMapReaderNotifty<TOutput> : ISectorMapReader<TOutput> {
        public ISectorMapReader<TOutput> SectorReader { get; set; }

        public int SectorSize { get => SectorReader.SectorSize; set => SectorReader.SectorSize = value; }
        public int LeftChunkCount { get => SectorReader.LeftChunkCount; set => SectorReader.LeftChunkCount = value; }
        public BinaryReader Reader { get => SectorReader.Reader; set => SectorReader.Reader = value; }

        public event EventHandler OnFinishedReading;

        public SectorMapReaderNotifty(ISectorMapReader<TOutput> sectorReader) {
            SectorReader = sectorReader;
        }

        public bool ReadNext(out TOutput[] sector) {
            bool notFinished = SectorReader.ReadNext(out sector);

            if (!notFinished) {
                OnFinishedReading.Invoke(this, EventArgs.Empty);
            }

            return notFinished;
        }
    }
}
