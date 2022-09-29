#define USE_PARALLEL
// #define CHECK_ELAPSED_TIME

using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace HydrogenAtomSchrodinger.Models
{
    public class HeatMapRenderer
    {
        private const int PixelWidth = 600;
        private const int PixelHeight = 600;

        private double _PlotAreaLength = 5.0;
        public double PlotAreaLength
        {
            get => _PlotAreaLength;
            set => _PlotAreaLength = value;
        }

        public BohrRadiusScaleEnum BohrRadiusScale = BohrRadiusScaleEnum.BRS5;
        public ScottPlot.Drawing.Colormap SelectedColorMap = ScottPlot.Drawing.Colormap.Turbo;

        public MaxValueEnum MaxValueType = MaxValueEnum.MV_DEFAULT;
        public double MaxValue = -1;

        private static BitmapImage BmpImageFromBmp(System.Drawing.Bitmap bmp)
        {
            using var memory = new System.IO.MemoryStream();
            bmp.Save(memory, System.Drawing.Imaging.ImageFormat.Png);
            memory.Position = 0;

            var bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.StreamSource = memory;
            bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
            bitmapImage.EndInit();
            bitmapImage.Freeze();

            return bitmapImage;
        }

        public WriteableBitmap Render(HydrogenAtomWaveFunction hydrogenAtomWaveFunction)
        {
            var plt = new ScottPlot.Plot(PixelWidth, PixelHeight);
            double[,] intensities = new double[PixelHeight, PixelWidth];

#if CHECK_ELAPSED_TIME
            var sw = new System.Diagnostics.Stopwatch();
            sw.Start();
#endif

#if USE_PARALLEL
            Parallel.For(0, PixelHeight, h =>
            {
                for (int w = 0; w < PixelWidth; w++)
                {
                    double x = PlotAreaLength * ((double)w / PixelWidth - 0.5);
                    double z = PlotAreaLength * ((double)h / PixelHeight - 0.5);
                    intensities[h, w] = hydrogenAtomWaveFunction.GetProbabilityDensityFromXZ(x, z);
                }
            });
#else
            for (int h = 0; h < PixelHeight; h++)
            {
                for (int w = 0; w < PixelWidth; w++)
                {
                    double x = PlotAreaLength * ((double) w / PixelWidth - 0.5);
                    double z = PlotAreaLength * ((double) h / PixelHeight - 0.5);
                    intensities[h, w] = hydrogenAtomWaveFunction.GetProbabilityDensityFromXZ(x, z);
                }
            }
#endif

#if CHECK_ELAPSED_TIME
            sw.Stop();
            System.Windows.MessageBox.Show($"{sw.Elapsed}");
#endif

            var hm = plt.AddHeatmap(intensities, SelectedColorMap, lockScales: false);
            hm.CellWidth = PlotAreaLength / PixelWidth;
            hm.CellHeight = PlotAreaLength / PixelHeight;
            hm.OffsetX = - PlotAreaLength / 2.0;
            hm.OffsetY = - PlotAreaLength / 2.0;

            if (MaxValue > 0)
            {
                hm.Update(intensities, min: 0, max: MaxValue);
            }
            else
            {
                hm.Update(intensities);
            }

            // Z-axis's pixel is arranged from top to down.
            // So, the generated bitmap needs to be flipped.
            hm.FlipVertically = true;

            var cb = plt.AddColorbar(hm);

            // configure the colorbar to display inequality operators at the edges
            if (MaxValue > 0)
            {
                cb.MaxIsClipped = true;
            }

            // Display up to 5 decimal places
            cb.AutomaticTicks(formatter: position => $"{position:F5}");

            // Change Style
            // plt.Style(Style.Black);

            return new WriteableBitmap(BmpImageFromBmp(plt.Render()));
        }
    }
}
