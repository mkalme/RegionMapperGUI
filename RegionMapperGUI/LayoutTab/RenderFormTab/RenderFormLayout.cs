using System;
using System.Drawing;

namespace RegionMapperGUI {
    public class RenderFormLayout : IRenderFormLayout {
        public RenderFormTab[] Tabs { get; private set; }

        private HeightmapLayoutProvider _heightmapLayoutProvider = new HeightmapLayoutProvider();
        private ILayoutObjectProvider<RenderLayout> _renderLayoutProvider = new RenderLayoutProvider();
        private ILayoutObjectProvider<AssetLayout> _assetLayoutProvider = new AssetLayoutProvider();        

        public RenderFormLayout() {
            Tabs = new RenderFormTab[3] {
                new RenderFormTab("Heightmap", _heightmapLayoutProvider),
                new RenderFormTab("Render", _renderLayoutProvider),
                new RenderFormTab("Asset", _assetLayoutProvider)
            };
        }

        public Image Render() {
            AssetLayout assetLayout = _assetLayoutProvider.CreateObject();

            _heightmapLayoutProvider.BrowseLayout.AssetLayout = assetLayout;
            _heightmapLayoutProvider.SaveToayout.AssetLayout = assetLayout;

            HeightmapLayout heightmapLayout = _heightmapLayoutProvider.CreateObject();
            RenderLayout renderLayout = _renderLayoutProvider.CreateObject();

            return RegionMapperGUI.Render.RenderMap(heightmapLayout, renderLayout);
        }
    }
}
