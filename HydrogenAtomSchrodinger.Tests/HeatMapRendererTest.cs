using HydrogenAtomSchrodinger.Models;

namespace HydrogenAtomSchrodinger.Tests
{
    [TestClass]
    public class HeatMapRendererTest
    {
        private HeatMapRenderer _heatMapRenderer = new HeatMapRenderer();
        private HydrogenAtomWaveFunction _hydrogenAtomWaveFunction = new HydrogenAtomWaveFunction();

        [TestMethod]
        public void CheckRenderingTime()
        {
            _hydrogenAtomWaveFunction.PrincipalQuantumNumber = PrincipalQuantumNumberEnum.PQN1;
            _hydrogenAtomWaveFunction.AzimuthalQuantumNumber = AzimuthalQuantumNumberEnum.AQN0;
            _hydrogenAtomWaveFunction.MagneticQuantumNumber = MagneticQuantumNumberEnum.MQN0;

            for (int i = 0; i < 10; i++) {
                _hydrogenAtomWaveFunction.UpdateHydrogenAtomWaveFunction();
                _heatMapRenderer.Render(_hydrogenAtomWaveFunction);
            }

            _hydrogenAtomWaveFunction.PrincipalQuantumNumber = PrincipalQuantumNumberEnum.PQN4;
            _hydrogenAtomWaveFunction.AzimuthalQuantumNumber = AzimuthalQuantumNumberEnum.AQN3;
            _hydrogenAtomWaveFunction.MagneticQuantumNumber = MagneticQuantumNumberEnum.MQN_P3;

            for (int i = 0; i < 10; i++) {
                _hydrogenAtomWaveFunction.UpdateHydrogenAtomWaveFunction();
                _heatMapRenderer.Render(_hydrogenAtomWaveFunction);
            }

            _hydrogenAtomWaveFunction.PrincipalQuantumNumber = PrincipalQuantumNumberEnum.PQN4;
            _hydrogenAtomWaveFunction.AzimuthalQuantumNumber = AzimuthalQuantumNumberEnum.AQN2;
            _hydrogenAtomWaveFunction.MagneticQuantumNumber = MagneticQuantumNumberEnum.MQN_P2;

            for (int i = 0; i < 10; i++) {
                _hydrogenAtomWaveFunction.UpdateHydrogenAtomWaveFunction();
                _heatMapRenderer.Render(_hydrogenAtomWaveFunction);
            }

            _hydrogenAtomWaveFunction.PrincipalQuantumNumber = PrincipalQuantumNumberEnum.PQN3;
            _hydrogenAtomWaveFunction.AzimuthalQuantumNumber = AzimuthalQuantumNumberEnum.AQN1;
            _hydrogenAtomWaveFunction.MagneticQuantumNumber = MagneticQuantumNumberEnum.MQN_P1;

            for (int i = 0; i < 10; i++) {
                _hydrogenAtomWaveFunction.UpdateHydrogenAtomWaveFunction();
                _heatMapRenderer.Render(_hydrogenAtomWaveFunction);
            }

            _hydrogenAtomWaveFunction.PrincipalQuantumNumber = PrincipalQuantumNumberEnum.PQN2;
            _hydrogenAtomWaveFunction.AzimuthalQuantumNumber = AzimuthalQuantumNumberEnum.AQN1;
            _hydrogenAtomWaveFunction.MagneticQuantumNumber = MagneticQuantumNumberEnum.MQN0;

            for (int i = 0; i < 10; i++) {
                _hydrogenAtomWaveFunction.UpdateHydrogenAtomWaveFunction();
                _heatMapRenderer.Render(_hydrogenAtomWaveFunction);
            }
        }
    }
}
