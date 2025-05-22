using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using Heightmap;

namespace RegionMapperGUI {
    public partial class DataGridViewPanel : UserControl {
        public DataGridViewSelectedRowCollection SelectedRows => BlockDataGridView.SelectedRows;

        public IList<HeightmapAssetBlock> Blocks => _blocks;
        private IList<HeightmapAssetBlock> _blocks;

        private HeightmapSelection _selection;

        public DataGridViewPanel() {
            InitializeComponent();
            BlockDataGridView.SetDoubleBuffering();

            _selection = new HeightmapSelection(BlockDataGridView);
        }

        public void LoadGrid(IList<HeightmapAssetBlock> blocks) {
            _blocks = new List<HeightmapAssetBlock>(blocks);

            int firstVisibleRow = BlockDataGridView.FirstDisplayedScrollingRowIndex;

            BlockDataGridView.Rows.Clear();
            for (int i = 0; i < _blocks.Count; i++) {
                var block = _blocks[i];

                BlockDataGridView.Rows.Add(i, block.BlockCondition.Name, "Edit", HeightmapBlockTypeToString(block.Type), block.Enabled);
            }

            if (firstVisibleRow >= 0 && firstVisibleRow < BlockDataGridView.Rows.Count) {
                BlockDataGridView.FirstDisplayedScrollingRowIndex = firstVisibleRow;
            }

            BlockDataGridView.ClearSelection();
        }
        public void ClearSelection() {
            BlockDataGridView.ClearSelection();
        }
        public DataGridView.HitTestInfo HitTest(int x, int y) {
            return BlockDataGridView.HitTest(x, y);
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

        private void BlockDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0) {
                BlockPropertyEditorForm editor = new BlockPropertyEditorForm(_blocks[(int)BlockDataGridView.Rows[e.RowIndex].Cells[0].Value].BlockCondition);
                editor.ShowDialog();
            }
        }
        private void BlockDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0) return;
            var row = BlockDataGridView.Rows[e.RowIndex];

            if (e.ColumnIndex == 3) {
                _blocks[(int)row.Cells[0].Value].Type = StringToHeightmapBlockType(row.Cells[3].Value.ToString());
            } else if (e.ColumnIndex == 4) {
                _blocks[(int)row.Cells[0].Value].Enabled = (bool)row.Cells[4].Value;
            }
        }
    }
}
