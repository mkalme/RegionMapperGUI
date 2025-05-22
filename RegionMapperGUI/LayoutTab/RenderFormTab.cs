using System;

namespace RegionMapperGUI {
    public class RenderFormTab {
        public string TabName { get; set; }
        public ILayoutObjectProvider<object> LayoutObjectProvider { get; set; }

        public RenderFormTab(string tabName, ILayoutObjectProvider<object> layoutObjectProvider) {
            TabName = tabName;
            LayoutObjectProvider = layoutObjectProvider;
        }
    }
}
