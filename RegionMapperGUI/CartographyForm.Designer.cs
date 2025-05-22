
using InteractiveGUI;

namespace RegionMapperGUI {
    partial class CartographyForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.GlobalContainer = new System.Windows.Forms.TableLayoutPanel();
            this.TabContainer = new RegionMapperGUI.CustomTabControl();
            this.RenderPanel = new System.Windows.Forms.Panel();
            this.SaveImagePanel = new System.Windows.Forms.Panel();
            this.RenderButton = new System.Windows.Forms.Button();
            this.GlobalContainer.SuspendLayout();
            this.RenderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GlobalContainer
            // 
            this.GlobalContainer.ColumnCount = 1;
            this.GlobalContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.Controls.Add(this.TabContainer, 0, 0);
            this.GlobalContainer.Controls.Add(this.RenderPanel, 0, 1);
            this.GlobalContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GlobalContainer.Location = new System.Drawing.Point(10, 10);
            this.GlobalContainer.Name = "GlobalContainer";
            this.GlobalContainer.RowCount = 2;
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.GlobalContainer.Size = new System.Drawing.Size(780, 452);
            this.GlobalContainer.TabIndex = 1;
            // 
            // TabContainer
            // 
            this.TabContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabContainer.Location = new System.Drawing.Point(3, 3);
            this.TabContainer.Name = "TabContainer";
            this.TabContainer.SelectedIndex = 0;
            this.TabContainer.Size = new System.Drawing.Size(774, 407);
            this.TabContainer.TabIndex = 0;
            // 
            // RenderPanel
            // 
            this.RenderPanel.Controls.Add(this.SaveImagePanel);
            this.RenderPanel.Controls.Add(this.RenderButton);
            this.RenderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RenderPanel.Location = new System.Drawing.Point(0, 413);
            this.RenderPanel.Margin = new System.Windows.Forms.Padding(0);
            this.RenderPanel.Name = "RenderPanel";
            this.RenderPanel.Size = new System.Drawing.Size(780, 39);
            this.RenderPanel.TabIndex = 1;
            // 
            // SaveImagePanel
            // 
            this.SaveImagePanel.Location = new System.Drawing.Point(105, 11);
            this.SaveImagePanel.Name = "SaveImagePanel";
            this.SaveImagePanel.Size = new System.Drawing.Size(414, 25);
            this.SaveImagePanel.TabIndex = 2;
            // 
            // RenderButton
            // 
            this.RenderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RenderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.RenderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RenderButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RenderButton.Image = global::RegionMapperGUI.Properties.Resources._16pxRender;
            this.RenderButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RenderButton.Location = new System.Drawing.Point(3, 11);
            this.RenderButton.Name = "RenderButton";
            this.RenderButton.Padding = new System.Windows.Forms.Padding(5, 0, 2, 0);
            this.RenderButton.Size = new System.Drawing.Size(79, 25);
            this.RenderButton.TabIndex = 1;
            this.RenderButton.Text = "Render";
            this.RenderButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RenderButton.UseVisualStyleBackColor = false;
            this.RenderButton.Click += new System.EventHandler(this.RenderButton_Click);
            // 
            // CartographyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.GlobalContainer);
            this.Name = "CartographyForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cartography";
            this.GlobalContainer.ResumeLayout(false);
            this.RenderPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel GlobalContainer;
        private System.Windows.Forms.Button RenderButton;
        private CustomTabControl TabContainer;
        private System.Windows.Forms.Panel RenderPanel;
        private System.Windows.Forms.Panel SaveImagePanel;
    }
}

