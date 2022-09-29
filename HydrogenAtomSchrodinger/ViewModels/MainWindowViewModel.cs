using HydrogenAtomSchrodinger.Models;
using Prism.Mvvm;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;

namespace HydrogenAtomSchrodinger.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private HeatMapRenderer _heatMapRenderer = new HeatMapRenderer();
        private HydrogenAtomWaveFunction _hydrogenAtomWaveFunction = new HydrogenAtomWaveFunction();

        private string _title = "Electron Probability Density Functions for Hydrogen Atom";
        public string Title
        {
            get { return _title; }
        }

        private WriteableBitmap _imageSource;
        public WriteableBitmap ImageSource
        {
            get { return _imageSource; }
            set { SetProperty(ref _imageSource, value); }
        }


        public PrincipalQuantumNumberEnum PrincipalQuantumNumber
        {
            get { return _hydrogenAtomWaveFunction.PrincipalQuantumNumber; }
            set
            {
                _updatingPrincipalQuantumNumber = true;

                switch (value)
                {
                    case PrincipalQuantumNumberEnum.PQN1:
                        AQN1_Visible = false;
                        AQN2_Visible = false;
                        AQN3_Visible = false;
                        break;
                    case PrincipalQuantumNumberEnum.PQN2:
                        AQN1_Visible = true;
                        AQN2_Visible = false;
                        AQN3_Visible = false;
                        break;
                    case PrincipalQuantumNumberEnum.PQN3:
                        AQN1_Visible = true;
                        AQN2_Visible = true;
                        AQN3_Visible = false;
                        break;
                    case PrincipalQuantumNumberEnum.PQN4:
                        AQN1_Visible = true;
                        AQN2_Visible = true;
                        AQN3_Visible = true;
                        break;
                }

                AzimuthalQuantumNumber = AzimuthalQuantumNumberEnum.AQN0;
                _updatingPrincipalQuantumNumber = false;

                SetProperty(ref _hydrogenAtomWaveFunction.PrincipalQuantumNumber, value);
            }
        }

        private bool _updatingPrincipalQuantumNumber;

        public AzimuthalQuantumNumberEnum AzimuthalQuantumNumber
        {
            get { return _hydrogenAtomWaveFunction.AzimuthalQuantumNumber; }
            set
            {
                _updatingAzimuthalQuantumNumber = true;

                switch (value)
                {
                    case AzimuthalQuantumNumberEnum.AQN0:
                        MQN1_Visible = false;
                        MQN2_Visible = false;
                        MQN3_Visible = false;
                        break;
                    case AzimuthalQuantumNumberEnum.AQN1:
                        MQN1_Visible = true;
                        MQN2_Visible = false;
                        MQN3_Visible = false;
                        break;
                    case AzimuthalQuantumNumberEnum.AQN2:
                        MQN1_Visible = true;
                        MQN2_Visible = true;
                        MQN3_Visible = false;
                        break;
                    case AzimuthalQuantumNumberEnum.AQN3:
                        MQN1_Visible = true;
                        MQN2_Visible = true;
                        MQN3_Visible = true;
                        break;
                }

                MagneticQuantumNumber = MagneticQuantumNumberEnum.MQN0;
                _updatingAzimuthalQuantumNumber = false;

                SetProperty(ref _hydrogenAtomWaveFunction.AzimuthalQuantumNumber, value);
            }
        }

        private bool _updatingAzimuthalQuantumNumber;

        public MagneticQuantumNumberEnum MagneticQuantumNumber
        {
            get { return _hydrogenAtomWaveFunction.MagneticQuantumNumber; }
            set { SetProperty(ref _hydrogenAtomWaveFunction.MagneticQuantumNumber, value); }
        }


        private bool _AQN1_Visible = false;
        public bool AQN1_Visible
        {
            get { return _AQN1_Visible; }
            set { SetProperty(ref _AQN1_Visible, value); }
        }

        private bool _AQN2_Visible = false;
        public bool AQN2_Visible
        {
            get { return _AQN2_Visible; }
            set { SetProperty(ref _AQN2_Visible, value); }
        }

        private bool _AQN3_Visible = false;
        public bool AQN3_Visible
        {
            get { return _AQN3_Visible; }
            set { SetProperty(ref _AQN3_Visible, value); }
        }


        private bool _MQN1_Visible = false;
        public bool MQN1_Visible
        {
            get { return _MQN1_Visible; }
            set { SetProperty(ref _MQN1_Visible, value); }
        }

        private bool _MQN2_Visible = false;
        public bool MQN2_Visible
        {
            get { return _MQN2_Visible; }
            set { SetProperty(ref _MQN2_Visible, value); }
        }

        private bool _MQN3_Visible = false;
        public bool MQN3_Visible
        {
            get { return _MQN3_Visible; }
            set { SetProperty(ref _MQN3_Visible, value); }
        }

        public BohrRadiusScaleEnum BohrRadiusScale
        {
            get { return  _heatMapRenderer.BohrRadiusScale; }
            set
            {
                switch (value)
                {
                    case BohrRadiusScaleEnum.BRS5:
                        _heatMapRenderer.PlotAreaLength = 5.0;
                        break;
                    case BohrRadiusScaleEnum.BRS10:
                        _heatMapRenderer.PlotAreaLength = 10.0;
                        break;
                    case BohrRadiusScaleEnum.BRS20:
                        _heatMapRenderer.PlotAreaLength = 20.0;
                        break;
                    case BohrRadiusScaleEnum.BRS40:
                        _heatMapRenderer.PlotAreaLength = 40.0;
                        break;
                    case BohrRadiusScaleEnum.BRS80:
                        _heatMapRenderer.PlotAreaLength = 80.0;
                        break;
                }
                SetProperty(ref _heatMapRenderer.BohrRadiusScale, value);
            }
        }

        private static ObservableCollection<ScottPlot.Drawing.Colormap> _ColorMaps = new ObservableCollection<ScottPlot.Drawing.Colormap>
        {
            ScottPlot.Drawing.Colormap.Turbo,
            ScottPlot.Drawing.Colormap.Algae,
            ScottPlot.Drawing.Colormap.Amp,
            ScottPlot.Drawing.Colormap.Balance,
            ScottPlot.Drawing.Colormap.Blues,
            ScottPlot.Drawing.Colormap.Curl,
            ScottPlot.Drawing.Colormap.Deep,
            ScottPlot.Drawing.Colormap.Delta,
            ScottPlot.Drawing.Colormap.Dense,
            ScottPlot.Drawing.Colormap.Diff,
            ScottPlot.Drawing.Colormap.Grayscale,
            ScottPlot.Drawing.Colormap.GrayscaleR,
            ScottPlot.Drawing.Colormap.Greens,
            ScottPlot.Drawing.Colormap.Haline,
            ScottPlot.Drawing.Colormap.Ice,
            ScottPlot.Drawing.Colormap.Inferno,
            ScottPlot.Drawing.Colormap.Jet,
            ScottPlot.Drawing.Colormap.Magma,
            ScottPlot.Drawing.Colormap.Matter,
            ScottPlot.Drawing.Colormap.Oxy,
            ScottPlot.Drawing.Colormap.Phase,
            ScottPlot.Drawing.Colormap.Plasma,
            ScottPlot.Drawing.Colormap.Rain,
            ScottPlot.Drawing.Colormap.Solar,
            ScottPlot.Drawing.Colormap.Speed,
            ScottPlot.Drawing.Colormap.Tarn,
            ScottPlot.Drawing.Colormap.Tempo,
            ScottPlot.Drawing.Colormap.Thermal,
            ScottPlot.Drawing.Colormap.Topo,
            ScottPlot.Drawing.Colormap.Turbid,
            ScottPlot.Drawing.Colormap.Viridis
        };
        public ObservableCollection<ScottPlot.Drawing.Colormap> ColorMaps
        {
            get => _ColorMaps;
        }

        public ScottPlot.Drawing.Colormap SelectedColorMap
        {
            get { return _heatMapRenderer.SelectedColorMap; }
            set { SetProperty(ref _heatMapRenderer.SelectedColorMap, value); }
        }

        public MaxValueEnum MaxValueType
        {
            get { return  _heatMapRenderer.MaxValueType; }
            set
            {
                switch (value)
                {
                    case MaxValueEnum.MV_DEFAULT:
                        _heatMapRenderer.MaxValue = -1;
                        break;
                    case MaxValueEnum.MV_001:
                        _heatMapRenderer.MaxValue = 0.01;
                        break;
                    case MaxValueEnum.MV_0001:
                        _heatMapRenderer.MaxValue = 0.001;
                        break;
                    case MaxValueEnum.MV_00001:
                        _heatMapRenderer.MaxValue = 0.0001;
                        break;
                }
                SetProperty(ref _heatMapRenderer.MaxValueType, value);
            }
        }

        public MainWindowViewModel()
        {
            PropertyChanged += UpdateImageWithPropertyChanged;
        }

        private void UpdateImageWithPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (_updatingPrincipalQuantumNumber || _updatingAzimuthalQuantumNumber)
            {
                return;
            }

            if (e.PropertyName != nameof(ImageSource))
            {
                _hydrogenAtomWaveFunction.UpdateHydrogenAtomWaveFunction();
                ImageSource = _heatMapRenderer.Render(_hydrogenAtomWaveFunction);
            }
        }
    }
}
