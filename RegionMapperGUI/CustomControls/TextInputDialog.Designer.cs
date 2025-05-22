
namespace RegionMapperGUI {
    partial class TextInputDialog {
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
            this.InputTextBox = new InteractiveGUI.DarkTextBox();
            this.InputLabel = new InteractiveGUI.DarkLabel();
            this.DoneButton = new InteractiveGUI.DarkButton();
            this.CancelButton = new InteractiveGUI.DarkButton();
            this.SuspendLayout();
            // 
            // InputTextBox
            // 
            this.InputTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InputTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.InputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputTextBox.CharacterType = InteractiveGUI.CharacterType.Regular;
            this.InputTextBox.HintText = "Path";
            this.InputTextBox.Location = new System.Drawing.Point(12, 23);
            this.InputTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.InputTextBox.Size = new System.Drawing.Size(309, 25);
            this.InputTextBox.TabIndex = 0;
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.InputLabel.Location = new System.Drawing.Point(9, 6);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(35, 15);
            this.InputLabel.TabIndex = 1;
            this.InputLabel.Text = "Label";
            // 
            // DoneButton
            // 
            this.DoneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.DoneButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.DoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoneButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DoneButton.Location = new System.Drawing.Point(12, 63);
            this.DoneButton.Margin = new System.Windows.Forms.Padding(0);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(75, 25);
            this.DoneButton.TabIndex = 2;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = false;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.CancelButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CancelButton.Location = new System.Drawing.Point(97, 63);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(0);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 25);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // TextInputDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(332, 101);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.InputTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TextInputDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Input";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private InteractiveGUI.DarkTextBox InputTextBox;
        private InteractiveGUI.DarkLabel InputLabel;
        private InteractiveGUI.DarkButton DoneButton;
        private InteractiveGUI.DarkButton CancelButton;
    }
}