using HydrogenAtomSchrodinger.Models;

namespace HydrogenAtomSchrodinger.Tests
{
    [TestClass]
    public class HeatMapRendererTest
    {
        private HeatMapRenderer _heatMapRenderer = new HeatMapRenderer();
        private HydrogenAtomWaveFunction _hydrogenAtomWaveFunction = new HydrogenAtomWaveFunction();

        [TestMethod]
        public void CheckRenderingTime_1s_x100()
        {
            _hydrogenAtomWaveFunction.PrincipalQuantumNumber = PrincipalQuantumNumberEnum.PQN1;
            _hydrogenAtomWaveFunction.AzimuthalQuantumNumber = AzimuthalQuantumNumberEnum.AQN0;
            _hydrogenAtomWaveFunction.MagneticQuantumNumber = MagneticQuantumNumberEnum.MQN0;

            for (int i = 0; i < 100; i++) {
                _hydrogenAtomWaveFunction.UpdateHydrogenAtomWaveFunction();
                _heatMapRenderer.Render(_hydrogenAtomWaveFunction);
            }
        }

        [TestMethod]
        public void CheckRenderingTime_4f3_x100()
        {
            _hydrogenAtomWaveFunction.PrincipalQuantumNumber = PrincipalQuantumNumberEnum.PQN4;
            _hydrogenAtomWaveFunction.AzimuthalQuantumNumber = AzimuthalQuantumNumberEnum.AQN3;
            _hydrogenAtomWaveFunction.MagneticQuantumNumber = MagneticQuantumNumberEnum.MQN_P3;

            for (int i = 0; i < 100; i++) {
                _hydrogenAtomWaveFunction.UpdateHydrogenAtomWaveFunction();
                _heatMapRenderer.Render(_hydrogenAtomWaveFunction);
            }
        }
    }
}
