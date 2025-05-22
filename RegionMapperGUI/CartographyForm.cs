using System;
using System.Windows.Forms;
using System.Drawing;
using InteractiveGUI;
using System.Reflection;
using System.IO;
using System.Drawing.Imaging;

namespace RegionMapperGUI {
    public partial class CartographyForm : Form {
        public IRenderFormLayout RenderFormLayout { get; set; } = new RenderFormLayout();

        private ImageViewerForm _form;
        private bool _formOpened = false;

        private string _renderedImagePath = "";
        private InteractiveField _field;

        public CartographyForm() {
            InitializeComponent();
            PopulateTabs();

            _form = new ImageViewerForm();
            _form.Load += ImageViewerForm_Open;
            _form.FormClosing += ImageViewerForm_Closing;
            _form.Text = "Rendered map";

            _field = new InteractiveField();
            _field.Field = GetType().GetField("_renderedImagePath", BindingFlags.Instance | BindingFlags.NonPublic);
            _field.Owner = this;
            _field.ControlInput = new BrowserInput(BrowseType.SaveAs, "Image files (*.png; *.jpeg; *.bmp) | *.png; *.jpeg; *.bmp");
            _field.DisplayName = "";
            _field.Control = _field.ControlInput.CreateControl(_field);

            SaveImagePanel.Controls.Add(_field.Control);
        }

        private void PopulateTabs() {
            foreach (var tab in RenderFormLayout.Tabs) {
                TabPage page = new TabPage();
                page.Text = tab.TabName;
                page.BackColor = Color.FromArgb(40, 40, 40);

                page.Controls.Add(tab.LayoutObjectProvider.CreateControl());

                TabContainer.TabPages.Add(page);
            }
        }

        private void RenderButton_Click(object sender, EventArgs e) {
            _form.Image = RenderFormLayout.Render();

            _field.ControlInput.TryParse(_field, out object pathObject);
            string path = pathObject as string;

            if (!string.IsNullOrEmpty(path)) {
                using (FileStream file = File.Create(path)) {
                    _form.Image.Save(file, ParseImageFormat(Path.GetExtension(path).Replace(".", "")));
                }
            }

            if (!_formOpened) {
                _form.Show();
            }
        }

        private static ImageFormat ParseImageFormat(string str) {
            return (ImageFormat)typeof(ImageFormat)
                    .GetProperty(str, BindingFlags.Public | BindingFlags.Static | BindingFlags.IgnoreCase)
                    .GetValue(str, null);
        }

        private void ImageViewerForm_Open(object sender, EventArgs e) {
            _formOpened = true;
        }
        private void ImageViewerForm_Closing(object sender, FormClosingEventArgs e) {
            e.Cancel = true;

            _form.Hide();
            _form.Image = null;

            _formOpened = false;
        }
    }
}
