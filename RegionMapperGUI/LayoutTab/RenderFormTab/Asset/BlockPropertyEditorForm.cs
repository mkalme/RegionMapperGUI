using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using Heightmap;
using AssetManagementSystem;

namespace RegionMapperGUI {
    public partial class BlockPropertyEditorForm : Form {
        public BlockCondition<HeightmapBlockType> BlockCondition { get; set; }

        private IDictionary<int, (string, HeightmapBlockType)> _list;
        private HeightmapSelection _selection;

        public BlockPropertyEditorForm(BlockCondition<HeightmapBlockType> blockCondition) {
            InitializeComponent();
            PropertyDataGridView.SetDoubleBuffering();

            PropertyContextMenuStrip.Renderer = new ToolStripProfessionalRenderer(new MyColors());

            _selection = new HeightmapSelection(PropertyDataGridView);

            BlockCondition = blockCondition;

            _list = CreateListFromBlockCondition(BlockCondition);
            LoadDataGridView(_list);
        }

        private void LoadDataGridView(IDictionary<int, (string, HeightmapBlockType)> displayedList) {
            PropertyDataGridView.Rows.Clear();
            for (int i = 0; i < _list.Count; i++) {
                var property = _list.ElementAt(i);

                PropertyDataGridView.Rows.Add(property.Key, property.Value.Item1, HeightmapBlockTypeToString(property.Value.Item2));
            }

            PropertyDataGridView.ClearSelection();
        }

        private static string HeightmapBlockTypeToString(HeightmapBlockType type) {
            switch (type) {
                case HeightmapBlockType.StopAtEncounter:
                    return "Stop at encounter";
                case HeightmapBlockType.SemiTransparent:
                    return "Semi-transparent";
                case HeightmapBlockType.None:
                    return "None";
            }

            return "";
        }
        private static HeightmapBlockType StringToHeightmapBlockType(string text) {
            switch (text) {
                case "Stop at encounter":
                    return HeightmapBlockType.StopAtEncounter;
                case "Semi-transparent":
                    return HeightmapBlockType.SemiTransparent;
                default:
                    return HeightmapBlockType.None;
            }
        }

        private static IDictionary<int, (string, HeightmapBlockType)> CreateListFromBlockCondition(BlockCondition<HeightmapBlockType> blockCondition) {
            Dictionary<int, (string, HeightmapBlockType)> output = new Dictionary<int, (string, HeightmapBlockType)>();

            int count = 0;
            foreach (var property in blockCondition.PropertyCollection.Conditions) {
                output.Add(count++, (PropertyToString(property), property.Value));
            }

            return output;
        }

        private void BlockPropertyEditorForm_Load(object sender, EventArgs e) {
            PropertyDataGridView.ClearSelection();
        }

        private void PropertyDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            EditProperty(e.RowIndex);
        }

        private void AddToolStripItem_Click(object sender, EventArgs e) {
            TextInputDialog dialog = new TextInputDialog("New property");
            dialog.ShowDialog();

            if (dialog.InputResult == DialogInputResult.Done) {
                var block = (dialog.InputText, BlockCondition.DefaultValue);

                _list.Add(_list.Count, block);
                LoadDataGridView(_list);
            }
        }
        private void RemoveToolStripitem_Click(object sender, EventArgs e) {
            foreach (DataGridViewRow row in PropertyDataGridView.SelectedRows) {
                int index = (int)row.Cells[0].Value;

                _list.Remove(index);
            }

            LoadDataGridView(_list);
        }
        private void EditToolStripitem_Click(object sender, EventArgs e) {
            Point point = PropertyDataGridView.PointToClient(PropertyContextMenuStrip.Bounds.Location);
            DataGridView.HitTestInfo hitTest = PropertyDataGridView.HitTest(point.X, point.Y);

            EditProperty(hitTest.RowIndex);
        }

        private void EditProperty(int rowIndex) {
            if (rowIndex < 0) return;

            var block = GetBlock(rowIndex);

            TextInputDialog dialog = new TextInputDialog("Edit property", block.Item1);
            dialog.ShowDialog();

            if (dialog.InputResult == DialogInputResult.Done) {
                block.Item1 = dialog.InputText;
                _list[(int)PropertyDataGridView.Rows[rowIndex].Cells[0].Value] = block;

                LoadDataGridView(_list);
            }
        }

        private (string, HeightmapBlockType) GetBlock(int rowIndex) {
            return _list[GetBlockIndex(rowIndex)];
        }
        private int GetBlockIndex(int rowIndex) {
            return (int)PropertyDataGridView.Rows[rowIndex].Cells[0].Value;
        }

        private static string PropertyToString(PropertyCondition<HeightmapBlockType> property) {
            return $"{property.Name}={string.Join(',', property.PropertyHash)}";
        }
        private static PropertyCondition<HeightmapBlockType> PropertyFromString(string text, HeightmapBlockType type) {
            string[] equalsDivider = text.Split("=");

            return new PropertyCondition<HeightmapBlockType>(equalsDivider[0], equalsDivider[1].Split(","), type);
        }

        private void PropertyContextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e) {
            RemoveToolStripitem.Enabled = PropertyDataGridView.SelectedRows.Count > 0;
            EditToolStripitem.Enabled = PropertyDataGridView.SelectedRows.Count > 0;
        }

        private void PropertyDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0) return;
            var row = PropertyDataGridView.Rows[e.RowIndex];

            if (e.ColumnIndex == 2) {
                var block = GetBlock(e.RowIndex);
                _list[GetBlockIndex(e.RowIndex)] = (block.Item1, StringToHeightmapBlockType(row.Cells[2].Value.ToString()));
            }
        }

        private void DoneButton_Click(object sender, EventArgs e) {
            Dictionary<string, PropertyCondition<HeightmapBlockType>> conditions = new Dictionary<string, PropertyCondition<HeightmapBlockType>>(_list.Count);
            foreach (var property in _list) {
                var propertyCondition = PropertyFromString(property.Value.Item1, property.Value.Item2);

                if (conditions.ContainsKey(propertyCondition.Name)) {
                    conditions[propertyCondition.Name].PropertyHash.UnionWith(propertyCondition.PropertyHash);
                } else {
                    conditions.Add(propertyCondition.Name, propertyCondition);
                }
            }

            BlockCondition.PropertyCollection = new PropertyCollection<HeightmapBlockType>(conditions.Values.ToList());

            Close();
        }
    }
}
