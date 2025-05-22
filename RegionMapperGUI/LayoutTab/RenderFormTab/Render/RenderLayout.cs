using System;
using InteractiveGUI;

namespace RegionMapperGUI {
    public class RenderLayout {
        [Interactive("Altitude painter"), PropertyInput(ScaleType.Horizontal, "AverageY", "Range", "Increment")]
        public AltitudePainter AltitudePainter { get; set; } = new AltitudePainter();

        [Interactive("Non transparent elevation painter"), PropertyInput(ScaleType.Horizontal, "MainIncrement", "SecondIncrement")]
        public ElevationPainter NonTransparentElevationPainter { get; set; } = new ElevationPainter(25, 2);

        [Interactive("Semi transparent elevation painter"), PropertyInput(ScaleType.Horizontal, "MainIncrement", "SecondIncrement")]
        public ElevationPainter SemiTransparentElevationPainter { get; set; } = new ElevationPainter(40, 3);

        [Interactive("Light painter"), PropertyInput(ScaleType.Horizontal, "AmbientLight", "SunIntensity")]
        public LightPainter LightPainter { get; set; } = new LightPainter();
    }

    public class AltitudePainter {

        [Interactive("Average Y level")]
        public int AverageY { get; set; } = 70;

        [Interactive, TextPropertyInput("Min", "Max")]
        public RangeLayout Range { get; set; } = new RangeLayout(-10, 20);

        [Interactive]
        public float Increment { get; set; } = 3;
    }

    public class RangeLayout {
        [Interactive]
        public int Min { get; set; }

        [Interactive]
        public int Max { get; set; }

        public RangeLayout(int min, int max) {
            Min = min;
            Max = max;
        }
    }

    public class ElevationPainter {

        [Interactive("Main increment")]
        public int MainIncrement { get; set; }
        
        [Interactive("Second increment")]
        public int SecondIncrement { get; set; }

        public ElevationPainter(int mainIncrement, int secondIncrement) {
            MainIncrement = mainIncrement;
            SecondIncrement = secondIncrement;
        }
    }

    public class LightPainter {

        [Interactive("Ambient light")]
        public float AmbientLight { get; set; } = 0.115F;
        
        [Interactive("Sun intensity")]
        public float SunIntensity { get; set; } = 1F;
    }

    public class FloatValidator : ValidatorAttribute {
        public override ValidateResult Validate(object input) {
            return false;
        }
    }
}
