using System;
using System.Windows.Forms;
using InteractiveGUI;

namespace RegionMapperGUI {
    public class HeightmapSaveInput : InputAttribute {
        private IInteractiveProperty _pathProperty;

        public override bool TryParse(IInteractiveProperty property, out object output) {
            CheckBoxDynamicPanel panel = property.Control as CheckBoxDynamicPanel;

            HeightmapSaveToLayout layout = property.GetValue() as HeightmapSaveToLayout;

            layout.DeleteAfterRender = panel.Checked;

            _pathProperty.ControlInput.TryParse(_pathProperty, out object text);
            layout.Path = text as string;

            output = layout;

            return true;
        }

        public override Control CreateControl(IInteractiveProperty property) {
            var layout = property.GetValue() as HeightmapSaveToLayout;

            _pathProperty = new InteractiveProperty(layout.GetType().GetProperty("Path"), "Path", new BrowserInput(BrowseType.SaveAs, "Rendered heightmap file | *.brhf"), new DefaultValidator());
            _pathProperty.Owner = layout;
            _pathProperty.Control = _pathProperty.ControlInput.CreateControl(_pathProperty);

            return new CheckBoxDynamicPanel(layout.DeleteAfterRender, "Delete after render", _pathProperty.Control, true);
        }
    }
}
