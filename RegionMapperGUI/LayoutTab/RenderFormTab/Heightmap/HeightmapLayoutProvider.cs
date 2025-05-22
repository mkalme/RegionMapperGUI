using System;

namespace RegionMapperGUI {
    public class HeightmapLayoutProvider : LayerLayoutObjectProvider<HeightmapLayout> {
        public BrowseLayoutProvider BrowseLayout { get; set; } = new BrowseLayoutProvider();
        public SaveToLayoutProvider SaveToayout { get; set; } = new SaveToLayoutProvider();

        public HeightmapLayoutProvider() : base(null){
            var browseItem = new LayoutObjectItem("Browse for an already existing heightmap file.",
                BrowseLayout);

            var saveToItem = new LayoutObjectItem("Create a new heightmap file.",
                SaveToayout);

            LayoutObjectItems = new LayoutObjectItem[] { saveToItem, browseItem };
        }
    }
}
