using System.Windows.Media.Effects;

namespace BISFormat.UI.Styles.Themes
{
    public static class Shadows
    {
        public static DropShadowEffect ShadowNone = new() { BlurRadius = 0, ShadowDepth = 0, Direction = 0, Color = Colors.DropShadowBackground, Opacity = 0, RenderingBias = RenderingBias.Performance };
        public static DropShadowEffect ShadowRight1 = new() { BlurRadius = 5, ShadowDepth = 1, Direction = 0, Color = Colors.DropShadowBackground, Opacity = .42, RenderingBias = RenderingBias.Performance };
        public static DropShadowEffect ShadowRight2 = new() { BlurRadius = 6, ShadowDepth = 1.5, Direction = 0, Color = Colors.DropShadowBackground, Opacity = .42, RenderingBias = RenderingBias.Performance };
        public static DropShadowEffect ShadowRight3 = new() { BlurRadius = 14, ShadowDepth = 4.5, Direction = 0, Color = Colors.DropShadowBackground, Opacity = .42, RenderingBias = RenderingBias.Performance };
        public static DropShadowEffect ShadowRight4 = new() { BlurRadius = 25, ShadowDepth = 8, Direction = 0, Color = Colors.DropShadowBackground, Opacity = .42, RenderingBias = RenderingBias.Performance };
        public static DropShadowEffect ShadowRight5 = new() { BlurRadius = 35, ShadowDepth = 13, Direction = 0, Color = Colors.DropShadowBackground, Opacity = .42, RenderingBias = RenderingBias.Performance };
        public static DropShadowEffect ShadowDown1 = new() { BlurRadius = 5, ShadowDepth = 1, Direction = 270, Color = Colors.DropShadowBackground, Opacity = .42, RenderingBias = RenderingBias.Performance };
        public static DropShadowEffect ShadowDown2 = new() { BlurRadius = 8, ShadowDepth = 1.5, Direction = 270, Color = Colors.DropShadowBackground, Opacity = .42, RenderingBias = RenderingBias.Performance };
        public static DropShadowEffect ShadowDown3 = new() { BlurRadius = 14, ShadowDepth = 4.5, Direction = 270, Color = Colors.DropShadowBackground, Opacity = .42, RenderingBias = RenderingBias.Performance };
        public static DropShadowEffect ShadowDown4 = new() { BlurRadius = 25, ShadowDepth = 8, Direction = 270, Color = Colors.DropShadowBackground, Opacity = .42, RenderingBias = RenderingBias.Performance };
        public static DropShadowEffect ShadowDown5 = new() { BlurRadius = 35, ShadowDepth = 13, Direction = 270, Color = Colors.DropShadowBackground, Opacity = .42, RenderingBias = RenderingBias.Performance };
        public static DropShadowEffect ShadowUp1 = new() { BlurRadius = 5, ShadowDepth = 1, Direction = 90, Color = Colors.DropShadowBackground, Opacity = .42, RenderingBias = RenderingBias.Performance };
        public static DropShadowEffect ShadowUp2 = new() { BlurRadius = 8, ShadowDepth = 1.5, Direction = 90, Color = Colors.DropShadowBackground, Opacity = .42, RenderingBias = RenderingBias.Performance };
        public static DropShadowEffect ShadowUp3 = new() { BlurRadius = 14, ShadowDepth = 4.5, Direction = 90, Color = Colors.DropShadowBackground, Opacity = .42, RenderingBias = RenderingBias.Performance };
        public static DropShadowEffect ShadowUp4 = new() { BlurRadius = 25, ShadowDepth = 8, Direction = 90, Color = Colors.DropShadowBackground, Opacity = .42, RenderingBias = RenderingBias.Performance };
        public static DropShadowEffect ShadowUp5 = new() { BlurRadius = 35, ShadowDepth = 13, Direction = 90, Color = Colors.DropShadowBackground, Opacity = .42, RenderingBias = RenderingBias.Performance };
        public static DropShadowEffect ShadowRound1 = new() { BlurRadius = 14, ShadowDepth = 4.5, Color = Colors.DropShadowBackground, Opacity = .42, RenderingBias = RenderingBias.Performance };
    }
}
