using System;
using System.Windows.Forms;

namespace RegionMapperGUI {
    public partial class TextInputDialog : Form {
        public string InputText {
            get => InputTextBox.Text;
            set => InputTextBox.Text = value;
        }

        public DialogInputResult InputResult { get; set; } = DialogInputResult.Cancel;

        public TextInputDialog(string inputLabelText, string text = "") {
            InitializeComponent();

            InputLabel.Text = inputLabelText;
            InputText = text;
        }

        private void DoneButton_Click(object sender, EventArgs e) {
            InputResult = DialogInputResult.Done;
            
            Close();
        }
        private void CancelButton_Click(object sender, EventArgs e) {
            InputResult = DialogInputResult.Cancel;

            Close();
        }
    }

    public enum DialogInputResult { 
        Done,
        Cancel
    }
}
