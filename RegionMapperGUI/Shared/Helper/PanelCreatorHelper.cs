using System;
using System.Windows.Forms;
using InteractiveGUI;

namespace RegionMapperGUI {
    public static class PanelCreatorHelper {
        public static Panel CreatePanel(object source, out IInteractiveProperty[] properties) {
            InputPanelCreator creator = new InputPanelCreator();
            creator.DisplayIcons = false;

            properties = new LayoutCreator().CreateLayout(source);

            Panel panel = creator.CreatePanel(properties);
            panel.Dock = DockStyle.Top;
            panel.AutoSize = true;
            panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel.Margin = new Padding(0);

            return panel;
        }
    }
}
