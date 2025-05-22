
namespace RegionMapperGUI {
    partial class RenderPanel {
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
            this.RenderTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // RenderTablePanel
            // 
            this.RenderTablePanel.AutoScroll = true;
            this.RenderTablePanel.ColumnCount = 1;
            this.RenderTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RenderTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RenderTablePanel.Location = new System.Drawing.Point(10, 10);
            this.RenderTablePanel.Margin = new System.Windows.Forms.Padding(0);
            this.RenderTablePanel.Name = "RenderTablePanel";
            this.RenderTablePanel.RowCount = 3;
            this.RenderTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.RenderTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.RenderTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.RenderTablePanel.Size = new System.Drawing.Size(722, 408);
            this.RenderTablePanel.TabIndex = 0;
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.Filter = "Json files (*.json)|*.json|Text files (*.txt)|*.txt";
            // 
            // RenderPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.RenderTablePanel);
            this.Name = "RenderPanel";
            this.Size = new System.Drawing.Size(742, 428);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel RenderTablePanel;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
    }
}
