using System;

namespace RegionMapperGUI {
    public interface IRenderSettingsReader {
        RenderLayout Read(string file);
    }
}
