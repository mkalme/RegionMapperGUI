using System;
using System.Windows.Forms;
using RegionMapper;
using Heightmap;

namespace RegionMapperGUI {
    public class AssetLayoutProvider : ILayoutObjectProvider<AssetLayout> {
        private AssetPanel _assetPanel;

        public Control CreateControl() {
            if (_assetPanel == null) {
                _assetPanel = new AssetPanel();
                _assetPanel.Dock = DockStyle.Fill;
            }

            return _assetPanel;
        }
        public AssetLayout CreateObject() {
            return new AssetLayout() {
                MapperAssetManager = MapperAssetManager.Asset,
                HeightmapAssetManager = new HeightmapAssetManager() {
                    Heightmap = _assetPanel.CreateAsset()
                }
            };
        }
    }
}
