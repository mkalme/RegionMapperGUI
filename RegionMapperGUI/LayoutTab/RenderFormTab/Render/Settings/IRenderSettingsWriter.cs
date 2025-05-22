using System;

namespace RegionMapperGUI {
    public interface IRenderSettingsWriter {
        void Write(string file, RenderLayout layout);
    }
}
