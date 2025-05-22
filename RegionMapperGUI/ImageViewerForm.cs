using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace RegionMapperGUI {
    public partial class ImageViewerForm : Form {
        public Image Image {
            get => _image;
            set {
                _image = value;
                ResetImage();
            }
        }
        private Image _image;

        public IInformationProvider InformationProvider {
            get => _informationProvider;
            set {
                _informationProvider = value;
                _informationProvider.OnInformationUpdate += OnInformationPanelUpdate;

                UpdateInformationPanel();
            }
        }
        private IInformationProvider _informationProvider;

        public InterpolationMode InterpolationMode { get; set; } = InterpolationMode.HighQualityBicubic;

        public ImageViewerForm(Image image = null) {
            _image = image;

            InitializeComponent();
            LoadInterpolationComboBox();

            InformationProvider = new InformationProvider();

            CopyToClipboardButton.Focus();
        }

        private void LoadInterpolationComboBox() {
            foreach (var item in Enum.GetValues(typeof(InterpolationMode))) {
                if (item.Equals(InterpolationMode.Invalid)) continue;

                InterpolationComboBox.Items.Add(item);
            }

            InterpolationComboBox.SelectedItem = InterpolationMode;
        }

        private static Size GetFitSizeForImage(Size imageSize, Size container) {
            float ratio = container.Width / (float)imageSize.Width;

            if (imageSize.Height * ratio > container.Height) {
                ratio = container.Height / (float)imageSize.Height;
            }

            return new Size((int)(imageSize.Width * ratio), (int)(imageSize.Height * ratio));
        }
        private Bitmap ResizeImageToFit(Image image, Size container) {
            Size imageSize = GetFitSizeForImage(image.Size, container);

            return ResizeImage(image, imageSize.Width, imageSize.Height);
        }
        private Bitmap ResizeImage(Image image, int width, int height) {
            if (width == 0 || height == 0) return null;

            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage)) {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes()) {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private void ResetImage() {
            if (Image == null) return;
            PictureBox.Image = ResizeImageToFit(Image, PictureBox.Size);
        }

        private void PictureBox_SizeChanged(object sender, EventArgs e) {
            if (Image == null) return;

            if (PictureBox.Image != null) {
                Size size = GetFitSizeForImage(PictureBox.Image.Size, PictureBox.Size);
                if (size == PictureBox.Image.Size || size.Width == 0 || size.Height == 0) return;
            }

            ResetImage();
        }
        private void InterpolationComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            InterpolationMode = (InterpolationMode)InterpolationComboBox.SelectedItem;
            ResetImage();
        }

        private void UpdateInformationPanel() {
            InformationPanel.Visible = !string.IsNullOrEmpty(InformationProvider.Information);
            if (string.IsNullOrEmpty(InformationProvider.Information)) return;

            InformationLabel.Text = InformationProvider.Information;
        }
        private void OnInformationPanelUpdate(object sender, EventArgs e) {
            UpdateInformationPanel();
        }

        private void CopyToClipboardButton_Click(object sender, EventArgs e) {
            if(Image != null) Clipboard.SetImage(Image);
        }
    }

    public interface IInformationProvider { 
        string Information { get; }

        event EventHandler OnInformationUpdate;
    }

    public class InformationProvider : IInformationProvider {
        public string Information => "Started: 17.07.2021 02:32:17\nWidth: 850\nHeight: 750\nFOV: 45°\nPixels Rendered: 637500 \\ 637500 (100,00%)\nProgress Type: Finished(4,60 seconds)";

        public event EventHandler OnInformationUpdate;
    }
}
