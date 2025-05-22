using System;
using System.Drawing;

namespace RegionMapperGUI {
    public interface IRenderFormLayout {
        RenderFormTab[] Tabs { get; }

        Image Render();
    }
}
