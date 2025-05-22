
namespace RegionMapperGUI {
    partial class DataGridViewPanel {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BlockDataGridView = new System.Windows.Forms.DataGridView();
            this.IndecColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropertyColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TypeColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.EnabledColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BlockDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BlockDataGridView
            // 
            this.BlockDataGridView.AllowUserToAddRows = false;
            this.BlockDataGridView.AllowUserToDeleteRows = false;
            this.BlockDataGridView.AllowUserToResizeRows = false;
            this.BlockDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BlockDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BlockDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.BlockDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BlockDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.BlockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BlockDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IndecColumn,
            this.NameColumn,
            this.PropertyColumn,
            this.TypeColumn,
            this.EnabledColumn});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BlockDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.BlockDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BlockDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.BlockDataGridView.EnableHeadersVisualStyles = false;
            this.BlockDataGridView.Location = new System.Drawing.Point(0, 0);
            this.BlockDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.BlockDataGridView.Name = "BlockDataGridView";
            this.BlockDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BlockDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.BlockDataGridView.RowTemplate.Height = 25;
            this.BlockDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BlockDataGridView.Size = new System.Drawing.Size(705, 400);
            this.BlockDataGridView.TabIndex = 0;
            this.BlockDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BlockDataGridView_CellContentClick);
            this.BlockDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.BlockDataGridView_CellValueChanged);
            // 
            // IndecColumn
            // 
            this.IndecColumn.HeaderText = "";
            this.IndecColumn.Name = "IndecColumn";
            this.IndecColumn.ReadOnly = true;
            this.IndecColumn.Visible = false;
            // 
            // NameColumn
            // 
            this.NameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // PropertyColumn
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            this.PropertyColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.PropertyColumn.HeaderText = "Properties";
            this.PropertyColumn.Name = "PropertyColumn";
            this.PropertyColumn.ReadOnly = true;
            this.PropertyColumn.Width = 65;
            // 
            // TypeColumn
            // 
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            this.TypeColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.TypeColumn.HeaderText = "Type";
            this.TypeColumn.Items.AddRange(new object[] {
            "Stop at encounter",
            "Semi-transparent",
            "None"});
            this.TypeColumn.Name = "TypeColumn";
            this.TypeColumn.Width = 125;
            // 
            // EnabledColumn
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = false;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            this.EnabledColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.EnabledColumn.HeaderText = "Enabled";
            this.EnabledColumn.Name = "EnabledColumn";
            this.EnabledColumn.Width = 53;
            // 
            // DataGridViewPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.BlockDataGridView);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "DataGridViewPanel";
            this.Size = new System.Drawing.Size(705, 400);
            ((System.ComponentModel.ISupportInitialize)(this.BlockDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView BlockDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IndecColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewButtonColumn PropertyColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn TypeColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EnabledColumn;
    }
}
