using System;
using System.Windows.Forms;

namespace RegionMapperGUI {
    public class LayerLayoutObjectProvider<TOutput> : ILayoutObjectProvider<TOutput> {
        public LayoutObjectItem[] LayoutObjectItems { get; set; }

        private LayoutPanel _layoutPanel;

        public LayerLayoutObjectProvider(LayoutObjectItem[] layoutObjectItems) {
            LayoutObjectItems = layoutObjectItems;
        }

        public Control CreateControl() {
            if (_layoutPanel == null) _layoutPanel = new LayoutPanel(LayoutObjectItems);
            return _layoutPanel;
        }
        public TOutput CreateObject() {
            return (TOutput)_layoutPanel.GetSelectedLayoutObjectItem().LayoutObjectProvider.CreateObject();
        }
    }
}
