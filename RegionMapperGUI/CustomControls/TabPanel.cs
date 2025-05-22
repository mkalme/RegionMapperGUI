using System;
using System.Drawing;
using System.Windows.Forms;

namespace RegionMapperGUI {
    public partial class TabPanel : UserControl {
        public Color BorderColor { get; set; } = Color.FromArgb(170, 170, 170);

        public TabPanel() {
            InitializeComponent();

            this.SetDoubleBuffering();
        }

        private void TabPanel_Paint(object sender, PaintEventArgs e) {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, BorderColor, ButtonBorderStyle.Solid);
        }
    }
}
