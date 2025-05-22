
namespace RegionMapperGUI {
    partial class LayoutPanel {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.LayoutTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.LayoutComboBoxLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LayoutComboBox = new InteractiveGUI.DarkComboBox();
            this.ComboBoxLinePanel = new System.Windows.Forms.Panel();
            this.LayoutTablePanel.SuspendLayout();
            this.LayoutComboBoxLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LayoutTablePanel
            // 
            this.LayoutTablePanel.ColumnCount = 1;
            this.LayoutTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutTablePanel.Controls.Add(this.LayoutComboBoxLayoutPanel, 0, 0);
            this.LayoutTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutTablePanel.Location = new System.Drawing.Point(10, 10);
            this.LayoutTablePanel.Margin = new System.Windows.Forms.Padding(0);
            this.LayoutTablePanel.Name = "LayoutTablePanel";
            this.LayoutTablePanel.RowCount = 2;
            this.LayoutTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.LayoutTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutTablePanel.Size = new System.Drawing.Size(707, 408);
            this.LayoutTablePanel.TabIndex = 2;
            // 
            // LayoutComboBoxLayoutPanel
            // 
            this.LayoutComboBoxLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LayoutComboBoxLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.LayoutComboBoxLayoutPanel.ColumnCount = 1;
            this.LayoutComboBoxLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutComboBoxLayoutPanel.Controls.Add(this.LayoutComboBox, 0, 0);
            this.LayoutComboBoxLayoutPanel.Controls.Add(this.ComboBoxLinePanel, 0, 2);
            this.LayoutComboBoxLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutComboBoxLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.LayoutComboBoxLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.LayoutComboBoxLayoutPanel.Name = "LayoutComboBoxLayoutPanel";
            this.LayoutComboBoxLayoutPanel.RowCount = 4;
            this.LayoutComboBoxLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutComboBoxLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.LayoutComboBoxLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.LayoutComboBoxLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.LayoutComboBoxLayoutPanel.Size = new System.Drawing.Size(707, 48);
            this.LayoutComboBoxLayoutPanel.TabIndex = 0;
            // 
            // LayoutComboBox
            // 
            this.LayoutComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LayoutComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.LayoutComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LayoutComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LayoutComboBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LayoutComboBox.FormattingEnabled = true;
            this.LayoutComboBox.Location = new System.Drawing.Point(0, 6);
            this.LayoutComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.LayoutComboBox.Name = "LayoutComboBox";
            this.LayoutComboBox.Size = new System.Drawing.Size(326, 23);
            this.LayoutComboBox.TabIndex = 0;
            // 
            // ComboBoxLinePanel
            // 
            this.ComboBoxLinePanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ComboBoxLinePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBoxLinePanel.Location = new System.Drawing.Point(0, 38);
            this.ComboBoxLinePanel.Margin = new System.Windows.Forms.Padding(0);
            this.ComboBoxLinePanel.Name = "ComboBoxLinePanel";
            this.ComboBoxLinePanel.Size = new System.Drawing.Size(707, 1);
            this.ComboBoxLinePanel.TabIndex = 1;
            // 
            // LayoutPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LayoutTablePanel);
            this.Name = "LayoutPanel";
            this.LayoutTablePanel.ResumeLayout(false);
            this.LayoutComboBoxLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel LayoutTablePanel;
        private System.Windows.Forms.TableLayoutPanel LayoutComboBoxLayoutPanel;
        private InteractiveGUI.DarkComboBox LayoutComboBox;
        private System.Windows.Forms.Panel ComboBoxLinePanel;
    }
}
