using System;
using System.Windows.Forms;
using InteractiveGUI;

namespace RegionMapperGUI {
    public class InteractiveLayoutProvider<TOutput> : ILayoutObjectProvider<TOutput> {
        public IObjectParser ObjectParser { get; set; } = new ObjectParser();

        public TOutput Source { get; set; }

        private IInteractiveProperty[] _properties;

        public InteractiveLayoutProvider(TOutput source) {
            Source = source;
        }

        public Control CreateControl() {
            return PanelCreatorHelper.CreatePanel(Source, out _properties);
        }
        public TOutput CreateObject() {
            if (!ObjectParser.TryParse(_properties)) throw new Exception("The inputs coudln't be parsed");
            
            return Source;
        }
    }

    public class LayoutProviderCache<TOutput> : ILayoutObjectProvider<TOutput> {
        public ILayoutObjectProvider<TOutput> LayoutObjectProvider { get; set; }
        private Control _cache;

        public LayoutProviderCache(ILayoutObjectProvider<TOutput> layoutObjectProvider) {
            LayoutObjectProvider = layoutObjectProvider;
        }

        public Control CreateControl() {
            if (_cache == null) _cache = LayoutObjectProvider.CreateControl();
            return _cache;
        }
        public TOutput CreateObject() {
            return LayoutObjectProvider.CreateObject();
        }
    }
}
