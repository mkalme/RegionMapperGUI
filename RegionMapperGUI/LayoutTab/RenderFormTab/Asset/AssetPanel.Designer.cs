
namespace RegionMapperGUI {
    partial class AssetPanel {
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
            this.components = new System.ComponentModel.Container();
            this.DataGridViewPanel = new System.Windows.Forms.TableLayoutPanel();
            this.GridContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NewFromSelectionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewSelectionStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.AddNewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.NewButton = new InteractiveGUI.DarkButton();
            this.SaveButton = new InteractiveGUI.DarkButton();
            this.RemoveButton = new InteractiveGUI.DarkButton();
            this.OpenButton = new InteractiveGUI.DarkButton();
            this.AddButton = new InteractiveGUI.DarkButton();
            this.SearchTextBox = new InteractiveGUI.DarkTextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.BlockDataGridViewPanel = new RegionMapperGUI.DataGridViewPanel();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.DataGridViewPanel.SuspendLayout();
            this.GridContextMenuStrip.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridViewPanel
            // 
            this.DataGridViewPanel.ColumnCount = 1;
            this.DataGridViewPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DataGridViewPanel.ContextMenuStrip = this.GridContextMenuStrip;
            this.DataGridViewPanel.Controls.Add(this.SearchPanel, 0, 0);
            this.DataGridViewPanel.Controls.Add(this.BlockDataGridViewPanel, 0, 1);
            this.DataGridViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewPanel.Location = new System.Drawing.Point(10, 10);
            this.DataGridViewPanel.Margin = new System.Windows.Forms.Padding(0);
            this.DataGridViewPanel.Name = "DataGridViewPanel";
            this.DataGridViewPanel.RowCount = 2;
            this.DataGridViewPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.DataGridViewPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DataGridViewPanel.Size = new System.Drawing.Size(671, 369);
            this.DataGridViewPanel.TabIndex = 0;
            // 
            // GridContextMenuStrip
            // 
            this.GridContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.GridContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewFromSelectionMenuItem,
            this.NewSelectionStripSeparator,
            this.AddNewMenuItem,
            this.RemoveMenuItem});
            this.GridContextMenuStrip.Name = "GridContextMenuStrip";
            this.GridContextMenuStrip.Size = new System.Drawing.Size(181, 98);
            // 
            // NewFromSelectionMenuItem
            // 
            this.NewFromSelectionMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NewFromSelectionMenuItem.Image = global::RegionMapperGUI.Properties.Resources.Create_16x;
            this.NewFromSelectionMenuItem.Name = "NewFromSelectionMenuItem";
            this.NewFromSelectionMenuItem.Size = new System.Drawing.Size(180, 22);
            this.NewFromSelectionMenuItem.Text = "New from selection";
            this.NewFromSelectionMenuItem.Click += new System.EventHandler(this.NewFromSelectionMenuItem_Click);
            // 
            // NewSelectionStripSeparator
            // 
            this.NewSelectionStripSeparator.Name = "NewSelectionStripSeparator";
            this.NewSelectionStripSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // AddNewMenuItem
            // 
            this.AddNewMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AddNewMenuItem.Image = global::RegionMapperGUI.Properties.Resources.Add_16x;
            this.AddNewMenuItem.Name = "AddNewMenuItem";
            this.AddNewMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AddNewMenuItem.Text = "Add new";
            this.AddNewMenuItem.Click += new System.EventHandler(this.AddNewMenuItem_Click);
            // 
            // RemoveMenuItem
            // 
            this.RemoveMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RemoveMenuItem.Image = global::RegionMapperGUI.Properties.Resources.Trash_16x;
            this.RemoveMenuItem.Name = "RemoveMenuItem";
            this.RemoveMenuItem.Size = new System.Drawing.Size(180, 22);
            this.RemoveMenuItem.Text = "Remove";
            this.RemoveMenuItem.Click += new System.EventHandler(this.RemoveMenuItem_Click);
            // 
            // SearchPanel
            // 
            this.SearchPanel.Controls.Add(this.NewButton);
            this.SearchPanel.Controls.Add(this.SaveButton);
            this.SearchPanel.Controls.Add(this.RemoveButton);
            this.SearchPanel.Controls.Add(this.OpenButton);
            this.SearchPanel.Controls.Add(this.AddButton);
            this.SearchPanel.Controls.Add(this.SearchTextBox);
            this.SearchPanel.Controls.Add(this.SearchLabel);
            this.SearchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchPanel.Location = new System.Drawing.Point(0, 0);
            this.SearchPanel.Margin = new System.Windows.Forms.Padding(0);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(671, 25);
            this.SearchPanel.TabIndex = 0;
            // 
            // NewButton
            // 
            this.NewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.NewButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.NewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NewButton.Image = global::RegionMapperGUI.Properties.Resources.Create_16x;
            this.NewButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NewButton.Location = new System.Drawing.Point(415, 0);
            this.NewButton.Margin = new System.Windows.Forms.Padding(0);
            this.NewButton.Name = "NewButton";
            this.NewButton.Padding = new System.Windows.Forms.Padding(8, 0, 5, 0);
            this.NewButton.Size = new System.Drawing.Size(68, 25);
            this.NewButton.TabIndex = 4;
            this.NewButton.Text = "New";
            this.NewButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewButton.UseVisualStyleBackColor = false;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.SaveButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SaveButton.Image = global::RegionMapperGUI.Properties.Resources.Save_16x;
            this.SaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveButton.Location = new System.Drawing.Point(502, 0);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(0);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Padding = new System.Windows.Forms.Padding(8, 0, 5, 0);
            this.SaveButton.Size = new System.Drawing.Size(80, 25);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.RemoveButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RemoveButton.Image = global::RegionMapperGUI.Properties.Resources.Trash_16x;
            this.RemoveButton.Location = new System.Drawing.Point(330, 0);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(0);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(25, 25);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OpenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.OpenButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.OpenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.OpenButton.Image = global::RegionMapperGUI.Properties.Resources.OpenFile_16x;
            this.OpenButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OpenButton.Location = new System.Drawing.Point(591, 0);
            this.OpenButton.Margin = new System.Windows.Forms.Padding(0);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Padding = new System.Windows.Forms.Padding(8, 0, 5, 0);
            this.OpenButton.Size = new System.Drawing.Size(80, 25);
            this.OpenButton.TabIndex = 0;
            this.OpenButton.Text = "Open";
            this.OpenButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OpenButton.UseVisualStyleBackColor = false;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.AddButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AddButton.Image = global::RegionMapperGUI.Properties.Resources.Add_16x;
            this.AddButton.Location = new System.Drawing.Point(296, 0);
            this.AddButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(25, 25);
            this.AddButton.TabIndex = 3;
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SearchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTextBox.CharacterType = InteractiveGUI.CharacterType.Regular;
            this.SearchTextBox.HintText = "Path";
            this.SearchTextBox.Location = new System.Drawing.Point(42, 0);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.SearchTextBox.Size = new System.Drawing.Size(245, 25);
            this.SearchTextBox.TabIndex = 1;
            this.SearchTextBox.InputChanged += new System.EventHandler(this.SearchTextBox_InputChanged);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(-1, 4);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(42, 15);
            this.SearchLabel.TabIndex = 0;
            this.SearchLabel.Text = "Search";
            // 
            // BlockDataGridViewPanel
            // 
            this.BlockDataGridViewPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BlockDataGridViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BlockDataGridViewPanel.Location = new System.Drawing.Point(0, 34);
            this.BlockDataGridViewPanel.Margin = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.BlockDataGridViewPanel.Name = "BlockDataGridViewPanel";
            this.BlockDataGridViewPanel.Size = new System.Drawing.Size(671, 335);
            this.BlockDataGridViewPanel.TabIndex = 1;
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.Filter = "Json files (*.json)|*.json|Text files (*.txt)|*.txt";
            // 
            // AssetPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.DataGridViewPanel);
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Name = "AssetPanel";
            this.Size = new System.Drawing.Size(691, 389);
            this.Load += new System.EventHandler(this.AssetPanel_Load);
            this.DataGridViewPanel.ResumeLayout(false);
            this.GridContextMenuStrip.ResumeLayout(false);
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel DataGridViewPanel;
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.Label SearchLabel;
        private InteractiveGUI.DarkTextBox SearchTextBox;
        private InteractiveGUI.DarkButton AddButton;
        private InteractiveGUI.DarkButton RemoveButton;
        private InteractiveGUI.DarkButton SaveButton;
        private InteractiveGUI.DarkButton OpenButton;
        private InteractiveGUI.DarkButton NewButton;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.ContextMenuStrip GridContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem NewFromSelectionMenuItem;
        private DataGridViewPanel BlockDataGridViewPanel;
        private System.Windows.Forms.ToolStripSeparator NewSelectionStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem AddNewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveMenuItem;
    }
}
