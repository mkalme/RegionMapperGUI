using System;
using System.Windows.Forms;
using InteractiveGUI;

namespace RegionMapperGUI {
    public class CheckBoxDynamicPanel : TableLayoutPanel {
        private DarkCheckBox _checkBox = new DarkCheckBox();
        public Control Control { get; set; }
        public bool Inversed { get; private set; }

        public bool Checked => _checkBox.Checked;

        public CheckBoxDynamicPanel(bool isChecked, string text, Control control, bool inversed = false) {
            Control = control;
            Inversed = inversed;

            _checkBox.Text = text;
            _checkBox.Checked = isChecked;
            _checkBox.AutoSize = true;
            _checkBox.Padding = new Padding(0, 3, 2, 0);
            _checkBox.CheckedChanged += CheckBox_CheckedChanged;

            SetControlVisibility();

            ColumnCount = 2;
            ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            Controls.Add(_checkBox, 0, 0);
            Controls.Add(Control, 1, 0);

            Dock = DockStyle.Top;

            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Margin = new Padding(0);
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e) {
            SetControlVisibility();
        }

        private void SetControlVisibility() {
            Control.Visible = _checkBox.Checked ^ Inversed;
        }
    }
}
