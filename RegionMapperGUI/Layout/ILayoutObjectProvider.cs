using System;
using System.Windows.Forms;

namespace RegionMapperGUI {
    public interface ILayoutObjectProvider<out TOutput> {
        Control CreateControl();
        TOutput CreateObject();
    }
}
