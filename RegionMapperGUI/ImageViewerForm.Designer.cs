
namespace RegionMapperGUI {
    partial class ImageViewerForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.InterpoaltionPanel = new System.Windows.Forms.Panel();
            this.CopyToClipboardButton = new RegionMapperGUI.DarkButton();
            this.InterpolationComboBox = new System.Windows.Forms.ComboBox();
            this.InterpolationLabel = new System.Windows.Forms.Label();
            this.InformationPanel = new System.Windows.Forms.Panel();
            this.InformationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.InterpoaltionPanel.SuspendLayout();
            this.InformationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox.Location = new System.Drawing.Point(0, 0);
            this.PictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(990, 606);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            this.PictureBox.SizeChanged += new System.EventHandler(this.PictureBox_SizeChanged);
            // 
            // InterpoaltionPanel
            // 
            this.InterpoaltionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.InterpoaltionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.InterpoaltionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InterpoaltionPanel.Controls.Add(this.CopyToClipboardButton);
            this.InterpoaltionPanel.Controls.Add(this.InterpolationComboBox);
            this.InterpoaltionPanel.Controls.Add(this.InterpolationLabel);
            this.InterpoaltionPanel.Location = new System.Drawing.Point(12, 494);
            this.InterpoaltionPanel.Name = "InterpoaltionPanel";
            this.InterpoaltionPanel.Size = new System.Drawing.Size(166, 100);
            this.InterpoaltionPanel.TabIndex = 1;
            // 
            // CopyToClipboardButton
            // 
            this.CopyToClipboardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.CopyToClipboardButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.CopyToClipboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyToClipboardButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.CopyToClipboardButton.Image = global::RegionMapperGUI.Properties.Resources.Copy_16x;
            this.CopyToClipboardButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CopyToClipboardButton.Location = new System.Drawing.Point(10, 62);
            this.CopyToClipboardButton.Margin = new System.Windows.Forms.Padding(0);
            this.CopyToClipboardButton.Name = "CopyToClipboardButton";
            this.CopyToClipboardButton.Padding = new System.Windows.Forms.Padding(6, 0, 5, 0);
            this.CopyToClipboardButton.Size = new System.Drawing.Size(145, 25);
            this.CopyToClipboardButton.TabIndex = 0;
            this.CopyToClipboardButton.Text = "Copy to clipboard";
            this.CopyToClipboardButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CopyToClipboardButton.UseVisualStyleBackColor = false;
            this.CopyToClipboardButton.Click += new System.EventHandler(this.CopyToClipboardButton_Click);
            // 
            // InterpolationComboBox
            // 
            this.InterpolationComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.InterpolationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InterpolationComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InterpolationComboBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InterpolationComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.InterpolationComboBox.FormattingEnabled = true;
            this.InterpolationComboBox.Location = new System.Drawing.Point(10, 26);
            this.InterpolationComboBox.Name = "InterpolationComboBox";
            this.InterpolationComboBox.Size = new System.Drawing.Size(145, 25);
            this.InterpolationComboBox.TabIndex = 1;
            this.InterpolationComboBox.SelectedIndexChanged += new System.EventHandler(this.InterpolationComboBox_SelectedIndexChanged);
            // 
            // InterpolationLabel
            // 
            this.InterpolationLabel.AutoSize = true;
            this.InterpolationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.InterpolationLabel.Location = new System.Drawing.Point(27, 5);
            this.InterpolationLabel.Name = "InterpolationLabel";
            this.InterpolationLabel.Size = new System.Drawing.Size(109, 15);
            this.InterpolationLabel.TabIndex = 0;
            this.InterpolationLabel.Text = "Interpolation mode";
            // 
            // InformationPanel
            // 
            this.InformationPanel.AutoSize = true;
            this.InformationPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InformationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.InformationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InformationPanel.Controls.Add(this.InformationLabel);
            this.InformationPanel.Location = new System.Drawing.Point(12, 12);
            this.InformationPanel.Margin = new System.Windows.Forms.Padding(0);
            this.InformationPanel.Name = "InformationPanel";
            this.InformationPanel.Size = new System.Drawing.Size(13, 26);
            this.InformationPanel.TabIndex = 2;
            // 
            // InformationLabel
            // 
            this.InformationLabel.AutoSize = true;
            this.InformationLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InformationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.InformationLabel.Location = new System.Drawing.Point(5, 5);
            this.InformationLabel.Margin = new System.Windows.Forms.Padding(0, 0, 6, 6);
            this.InformationLabel.Name = "InformationLabel";
            this.InformationLabel.Size = new System.Drawing.Size(0, 13);
            this.InformationLabel.TabIndex = 0;
            // 
            // ImageViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(990, 606);
            this.Controls.Add(this.InformationPanel);
            this.Controls.Add(this.InterpoaltionPanel);
            this.Controls.Add(this.PictureBox);
            this.MinimumSize = new System.Drawing.Size(100, 100);
            this.Name = "ImageViewerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rendered map";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.InterpoaltionPanel.ResumeLayout(false);
            this.InterpoaltionPanel.PerformLayout();
            this.InformationPanel.ResumeLayout(false);
            this.InformationPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Panel InterpoaltionPanel;
        private System.Windows.Forms.Label InterpolationLabel;
        private System.Windows.Forms.ComboBox InterpolationComboBox;
        private DarkButton CopyToClipboardButton;
        private System.Windows.Forms.Panel InformationPanel;
        private System.Windows.Forms.Label InformationLabel;
    }
}