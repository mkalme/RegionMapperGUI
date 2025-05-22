using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using RegionMapper;
using Heightmap;
using AssetManagementSystem;
using WorldEditor;

namespace RegionMapperGUI {
    public partial class AssetPanel : TabPanel {
        private IList<HeightmapAssetBlock> _blocks = new List<HeightmapAssetBlock>();

        public AssetPanel() {
            InitializeComponent();
            GridContextMenuStrip.Renderer = new ToolStripProfessionalRenderer(new MyColors());

            MapperAssetManager.Initialize("_defaultTextures", "");
            _blocks = LoadBlocksFromAsset();

            BlockDataGridViewPanel.LoadGrid(_blocks);
        }

        private static List<HeightmapAssetBlock> LoadBlocksFromAsset() {
            var deserializer = new CustomHeightmapAssetManagerDeserializer(HeightmapAssetManager.AssetPath) {
                Blocks = new Dictionary<string, BlockCondition<HeightmapBlockType>>()
            };
            deserializer.Deserialize();

            List<HeightmapAssetBlock> blocks = new List<HeightmapAssetBlock>(deserializer.Blocks.Count);
            for (int i = 0; i < deserializer.Blocks.Count; i++) {
                BlockCondition<HeightmapBlockType> block = deserializer.Blocks.ElementAt(i).Value;

                blocks.Add(new HeightmapAssetBlock() {
                    BlockCondition = block,
                    Type = block.DefaultValue,
                    Enabled = true
                });
            }

            return blocks;
        }

        private void AssetPanel_Load(object sender, EventArgs e) {
            BlockDataGridViewPanel.ClearSelection();
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            SaveFileDialog.ShowDialog();
            if (string.IsNullOrEmpty(SaveFileDialog.FileName)) return;

            JsonHeightmapAssetPackWriter writer = new JsonHeightmapAssetPackWriter();
            writer.WritePack(SaveFileDialog.FileName, _blocks);
        }
        private void OpenButton_Click(object sender, EventArgs e) {
            OpenFileDialog.ShowDialog();
            if (string.IsNullOrEmpty(OpenFileDialog.FileName)) return;

            JsonHeightmapAssetPackReader reader = new JsonHeightmapAssetPackReader();
            _blocks = reader.ReadPack(OpenFileDialog.FileName);

            UpdateGrid(_blocks);
        }

        private void NewButton_Click(object sender, EventArgs e) {
            _blocks.Clear();
            BlockDataGridViewPanel.LoadGrid(_blocks);
        }

        private void AddButton_Click(object sender, EventArgs e) {
            AddNewBlock();
        }
        private void RemoveButton_Click(object sender, EventArgs e) {
            RemoveSelectedBlocks();
        }

        private void SearchTextBox_InputChanged(object sender, EventArgs e) {
            UpdateGrid(_blocks);
        }

        private void UpdateGrid(IList<HeightmapAssetBlock> blocks) {
            string text = SearchTextBox.Text;
            if (string.IsNullOrEmpty(text)) {
                BlockDataGridViewPanel.LoadGrid(blocks);
                return;
            }

            var list = blocks.Where(x => x.BlockCondition.Name.Contains(text)).ToList();
            if (list.Count != BlockDataGridViewPanel.Blocks.Count) {
                BlockDataGridViewPanel.LoadGrid(list);
            }
        }

        public IAsset<IBlock, HeightmapBlockType> CreateAsset() {
            var blocks = new Dictionary<string, BlockCondition<HeightmapBlockType>>(_blocks.Count);

            foreach (var block in _blocks) {
                if (!block.Enabled) continue;

                block.BlockCondition.DefaultValue = block.Type;
                blocks.Add(block.BlockCondition.Name, block.BlockCondition);
            }

            return new BlockConditionAsset<HeightmapBlockType>(blocks) { DefaultValue = HeightmapBlockType.None };
        }

        private void NewFromSelectionMenuItem_Click(object sender, EventArgs e) {
            List<HeightmapAssetBlock> blocks = new List<HeightmapAssetBlock>(BlockDataGridViewPanel.SelectedRows.Count);

            foreach (DataGridViewRow row in BlockDataGridViewPanel.SelectedRows) {
                int index = (int)row.Cells[0].Value;

                blocks.Add(BlockDataGridViewPanel.Blocks[index]);
            }

            _blocks = blocks;
            SearchTextBox.Text = "";
            UpdateGrid(_blocks);
        }

        private void AddNewMenuItem_Click(object sender, EventArgs e) {
            AddNewBlock();
        }
        private void RemoveMenuItem_Click(object sender, EventArgs e) {
            RemoveSelectedBlocks();
        }

        private void AddNewBlock() {
            var input = new TextInputDialog("Block name", "minecraft:");
            input.ShowDialog();

            if (input.InputResult == DialogInputResult.Done) {
                string name = input.InputText;

                if (_blocks.Where(x => x.BlockCondition.Name == name).Any()) {
                    MessageBox.Show("Block with that name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    _blocks.Insert(0, new HeightmapAssetBlock() {
                        BlockCondition = new BlockCondition<HeightmapBlockType>(name, HeightmapBlockType.StopAtEncounter, new PropertyCollection<HeightmapBlockType>()),
                        Type = HeightmapBlockType.StopAtEncounter,
                        Enabled = true
                    });

                    UpdateGrid(_blocks);
                }
            }
        }
        private void RemoveSelectedBlocks() {
            foreach (DataGridViewRow row in BlockDataGridViewPanel.SelectedRows) {
                var index = (int)row.Cells[0].Value;

                int indexObject = _blocks.IndexOf(BlockDataGridViewPanel.Blocks[index]);
                _blocks.RemoveAt(indexObject);
            }

            UpdateGrid(_blocks);
        }
    }

    public class MyColors : ProfessionalColorTable {
        public Color BackColor { get; set; } = Color.FromArgb(50, 50, 50);
        public Color HoverColor { get; set; } = Color.FromArgb(80, 80, 80);

        public override Color ImageMarginGradientBegin => BackColor;
        public override Color ImageMarginGradientMiddle => BackColor;
        public override Color ImageMarginGradientEnd => BackColor;

        public override Color MenuItemBorder => HoverColor;

        public override Color MenuItemSelectedGradientBegin => HoverColor;
        public override Color MenuItemSelectedGradientEnd => HoverColor;
    }
}
