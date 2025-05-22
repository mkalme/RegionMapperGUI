using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace RegionMapperGUI {
    public class CustomTabControl : TabControl {
        private const int TCM_ADJUSTRECT = 0x1328;

        protected override void WndProc(ref Message m) {
            if (m.Msg == TCM_ADJUSTRECT) {
                Rect rect = (Rect)(m.GetLParam(typeof(Rect)));
                rect.Left = this.Left - this.Margin.Left - 1;
                rect.Right = this.Right + this.Margin.Right + 1;

                rect.Top = this.Top - this.Margin.Top + 1;
                rect.Bottom = this.Bottom + this.Margin.Bottom + 1;
                Marshal.StructureToPtr(rect, m.LParam, true);
            }

            base.WndProc(ref m);
        }

        private struct Rect {
            public int Left, Top, Right, Bottom;
        }
    }
}
