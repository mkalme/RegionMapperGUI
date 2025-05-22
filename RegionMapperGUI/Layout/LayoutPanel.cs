using System;
using System.Windows.Forms;

namespace RegionMapperGUI {
    public partial class LayoutPanel : TabPanel {
        public LayoutObjectItem[] LayoutObjectProviders { get; set; }

        public LayoutPanel(LayoutObjectItem[] layoutObjectProviders) {
            LayoutObjectProviders = layoutObjectProviders;

            foreach (var layoutProvider in LayoutObjectProviders) {
                layoutProvider.LayoutObjectProvider = new LayoutProviderCache<object>(layoutProvider.LayoutObjectProvider);
            }

            InitializeComponent();
            InitializeComboBox();

            Dock = DockStyle.Fill;
        }

        private void InitializeComboBox() {
            foreach (var layout in LayoutObjectProviders) {
                LayoutComboBox.Items.Add(layout);
            }

            LayoutComboBox.SelectedIndexChanged += LayoutComboBox_SelectedIndexChanged;
            LayoutComboBox.SelectedItem = LayoutObjectProviders[0];
        }
        private void LayoutComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            var control = LayoutTablePanel.GetControlFromPosition(0, 1);
            if(control != null) LayoutTablePanel.Controls.Remove(control);

            var item = LayoutComboBox.SelectedItem as LayoutObjectItem;
            Control newControl = item.LayoutObjectProvider.CreateControl();

            LayoutTablePanel.Controls.Add(newControl, 0, 1);
        }

        public LayoutObjectItem GetSelectedLayoutObjectItem() {
            return LayoutComboBox.SelectedItem as LayoutObjectItem;
        }
    }

    public class LayoutObjectItem { 
        public string DisplayText { get; set; }
        public ILayoutObjectProvider<object> LayoutObjectProvider { get; set; }

        public LayoutObjectItem(string name, ILayoutObjectProvider<object> layoutObjectProvider) {
            DisplayText = name;
            LayoutObjectProvider = layoutObjectProvider;
        }

        public override string ToString() {
            return DisplayText;
        }
    }
}
