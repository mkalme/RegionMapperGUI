using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RegionMapperGUI {
    public partial class RenderPanel : TabPanel {
        public IRenderSettingsReader SettingsReader { get; set; } = new JsonRenderSettingsReader();
        public IRenderSettingsWriter SettingsWriter { get; set; } = new JsonRenderSettingsWriter();

        public InteractiveLayoutProvider<RenderLayout> LayoutProvider { get; set; }

        public RenderPanel() {
            InitializeComponent();

            Dock = DockStyle.Fill;

            DarkButton loadSettingsButton = CreateButton("Load settings", Properties.Resources.OpenFile_16x);
            loadSettingsButton.MouseClick += LoadButtonMouseClick;

            DarkButton saveSettingsButton = CreateButton("Save settings", Properties.Resources.Save_16x);
            saveSettingsButton.MouseClick += SaveButtonMouseClick;
            saveSettingsButton.Location = new Point(loadSettingsButton.Width + 9, 0);

            Panel buttonPanel = new Panel();
            buttonPanel.Controls.Add(loadSettingsButton);
            buttonPanel.Controls.Add(saveSettingsButton);

            buttonPanel.Margin = new Padding(0);

            buttonPanel.AutoSize = true;
            buttonPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            RenderTablePanel.Controls.Add(buttonPanel, 0, 2);

            LayoutProvider = new InteractiveLayoutProvider<RenderLayout>(new RenderLayout());
            RenderLayoutActivate();
        }

        private void RenderLayoutActivate() {
            Control control = RenderTablePanel.GetControlFromPosition(0, 0);
            if (control != null) {
                RenderTablePanel.Controls.Remove(control);
            }

            RenderTablePanel.Controls.Add(LayoutProvider.CreateControl(), 0, 0);
        }
        private static DarkButton CreateButton(string text, Image image) {
            DarkButton button = new DarkButton() {
                Text = text,
                ImageAlign = ContentAlignment.MiddleRight,
                TextAlign = ContentAlignment.MiddleLeft,
                Image = image,
                Width = 107,
                Padding = new Padding(0, 0, 2, 0)
            };

            return button;
        }

        private void LoadButtonMouseClick(object sender, EventArgs e) {
            OpenFileDialog.ShowDialog();

            if (File.Exists(OpenFileDialog.FileName)) {
                LayoutProvider.Source = SettingsReader.Read(OpenFileDialog.FileName);
                RenderLayoutActivate();
            }
        }
        private void SaveButtonMouseClick(object sender, EventArgs e) {
            SaveFileDialog.ShowDialog();
            if (string.IsNullOrEmpty(SaveFileDialog.FileName)) return;

            try {
                RenderLayout renderLayout = LayoutProvider.CreateObject();
                SettingsWriter.Write(SaveFileDialog.FileName, renderLayout);
            } catch { 
                
            }
        }
    }
}
