using System;
using System.Windows.Forms;

namespace RegionMapperGUI {
    public class RenderLayoutProvider : ILayoutObjectProvider<RenderLayout> {
        private RenderPanel _renderPanel;

        public Control CreateControl() {
            if (_renderPanel == null) _renderPanel = new RenderPanel();
            return _renderPanel;
        }
        public RenderLayout CreateObject() {
            return _renderPanel.LayoutProvider.CreateObject();
        }
    }
}
