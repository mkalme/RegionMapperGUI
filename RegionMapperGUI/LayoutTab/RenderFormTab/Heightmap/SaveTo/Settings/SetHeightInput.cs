using System;
using System.Windows.Forms;
using InteractiveGUI;

namespace RegionMapperGUI {
    public class SetHeightInput : InputAttribute {
        public override bool TryParse(IInteractiveProperty property, out object output) {
            HeightmapSettingsLayout layout = property.GetValue() as HeightmapSettingsLayout;
            CheckBoxDynamicPanel panel = property.Control as CheckBoxDynamicPanel;

            layout.SetHeightEnabled = panel.Checked;
            if (panel.Checked) layout.MaxHeight = short.Parse(panel.Control.Text);

            output = layout;
            return true;
        }

        public override Control CreateControl(IInteractiveProperty property) {
            var layout = property.GetValue() as HeightmapSettingsLayout;

            DarkTextBox textBox = new DarkTextBox();
            textBox.CharacterType = CharacterType.Numbers;
            textBox.Text = layout.MaxHeight.ToString();

            return new CheckBoxDynamicPanel(layout.SetHeightEnabled, "Use set height", textBox);
        }
    }
}
