
namespace RegionMapperGUI {
    partial class BlockPropertyEditorForm {
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PropertyDataGridView = new System.Windows.Forms.DataGridView();
            this.IndexColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropertyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PropertyContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveToolStripitem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.EditToolStripitem = new System.Windows.Forms.ToolStripMenuItem();
            this.DoneButton = new RegionMapperGUI.DarkButton();
            ((System.ComponentModel.ISupportInitialize)(this.PropertyDataGridView)).BeginInit();
            this.PropertyContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // PropertyDataGridView
            // 
            this.PropertyDataGridView.AllowUserToAddRows = false;
            this.PropertyDataGridView.AllowUserToDeleteRows = false;
            this.PropertyDataGridView.AllowUserToOrderColumns = true;
            this.PropertyDataGridView.AllowUserToResizeRows = false;
            this.PropertyDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PropertyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PropertyDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.PropertyDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PropertyDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.PropertyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PropertyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IndexColumn,
            this.PropertyColumn,
            this.TypeColumn});
            this.PropertyDataGridView.ContextMenuStrip = this.PropertyContextMenuStrip;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PropertyDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.PropertyDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.PropertyDataGridView.EnableHeadersVisualStyles = false;
            this.PropertyDataGridView.Location = new System.Drawing.Point(12, 12);
            this.PropertyDataGridView.Name = "PropertyDataGridView";
            this.PropertyDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PropertyDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.PropertyDataGridView.RowTemplate.Height = 25;
            this.PropertyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PropertyDataGridView.Size = new System.Drawing.Size(393, 217);
            this.PropertyDataGridView.TabIndex = 0;
            this.PropertyDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.PropertyDataGridView_CellMouseDoubleClick);
            this.PropertyDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.PropertyDataGridView_CellValueChanged);
            // 
            // IndexColumn
            // 
            this.IndexColumn.HeaderText = "";
            this.IndexColumn.Name = "IndexColumn";
            this.IndexColumn.ReadOnly = true;
            this.IndexColumn.Visible = false;
            // 
            // PropertyColumn
            // 
            this.PropertyColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PropertyColumn.HeaderText = "Property";
            this.PropertyColumn.Name = "PropertyColumn";
            this.PropertyColumn.ReadOnly = true;
            // 
            // TypeColumn
            // 
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            this.TypeColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.TypeColumn.HeaderText = "Type";
            this.TypeColumn.Items.AddRange(new object[] {
            "Stop at encounter",
            "Semi-transparent",
            "None"});
            this.TypeColumn.Name = "TypeColumn";
            this.TypeColumn.Width = 125;
            // 
            // PropertyContextMenuStrip
            // 
            this.PropertyContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PropertyContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripItem,
            this.RemoveToolStripitem,
            this.ToolStripSeparator,
            this.EditToolStripitem});
            this.PropertyContextMenuStrip.Name = "PropertyContextMenuStrip";
            this.PropertyContextMenuStrip.Size = new System.Drawing.Size(122, 76);
            this.PropertyContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.PropertyContextMenuStrip_Opening);
            // 
            // AddToolStripItem
            // 
            this.AddToolStripItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AddToolStripItem.Image = global::RegionMapperGUI.Properties.Resources.Add_16x;
            this.AddToolStripItem.Name = "AddToolStripItem";
            this.AddToolStripItem.Size = new System.Drawing.Size(121, 22);
            this.AddToolStripItem.Text = "Add new";
            this.AddToolStripItem.Click += new System.EventHandler(this.AddToolStripItem_Click);
            // 
            // RemoveToolStripitem
            // 
            this.RemoveToolStripitem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RemoveToolStripitem.Image = global::RegionMapperGUI.Properties.Resources.Trash_16x;
            this.RemoveToolStripitem.Name = "RemoveToolStripitem";
            this.RemoveToolStripitem.Size = new System.Drawing.Size(121, 22);
            this.RemoveToolStripitem.Text = "Remove";
            this.RemoveToolStripitem.Click += new System.EventHandler(this.RemoveToolStripitem_Click);
            // 
            // ToolStripSeparator
            // 
            this.ToolStripSeparator.Name = "ToolStripSeparator";
            this.ToolStripSeparator.Size = new System.Drawing.Size(118, 6);
            // 
            // EditToolStripitem
            // 
            this.EditToolStripitem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.EditToolStripitem.Image = global::RegionMapperGUI.Properties.Resources.Rename_16x;
            this.EditToolStripitem.Name = "EditToolStripitem";
            this.EditToolStripitem.Size = new System.Drawing.Size(121, 22);
            this.EditToolStripitem.Text = "Edit";
            this.EditToolStripitem.Click += new System.EventHandler(this.EditToolStripitem_Click);
            // 
            // DoneButton
            // 
            this.DoneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.DoneButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.DoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoneButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DoneButton.Location = new System.Drawing.Point(12, 254);
            this.DoneButton.Margin = new System.Windows.Forms.Padding(0);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(75, 25);
            this.DoneButton.TabIndex = 1;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = false;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // BlockPropertyEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(417, 292);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.PropertyDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BlockPropertyEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Property editor";
            this.Load += new System.EventHandler(this.BlockPropertyEditorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PropertyDataGridView)).EndInit();
            this.PropertyContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PropertyDataGridView;
        private DarkButton DoneButton;
        private System.Windows.Forms.ContextMenuStrip PropertyContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveToolStripitem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripitem;
        private System.Windows.Forms.DataGridViewTextBoxColumn IndexColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn TypeColumn;
    }
}