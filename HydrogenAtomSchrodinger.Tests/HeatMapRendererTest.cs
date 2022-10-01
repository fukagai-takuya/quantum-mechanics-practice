using HydrogenAtomSchrodinger.Models;

namespace HydrogenAtomSchrodinger.Tests
{
    [TestClass]
    public class HeatMapRendererTest
    {
        private HeatMapRenderer _heatMapRenderer = new HeatMapRenderer();
        private HydrogenAtomWaveFunction _hydrogenAtomWaveFunction = new HydrogenAtomWaveFunction();

        [TestMethod]
        public void CheckRenderingTime_1s()
        {
            _hydrogenAtomWaveFunction.PrincipalQuantumNumber = PrincipalQuantumNumberEnum.PQN1;
            _hydrogenAtomWaveFunction.AzimuthalQuantumNumber = AzimuthalQuantumNumberEnum.AQN0;
            _hydrogenAtomWaveFunction.MagneticQuantumNumber = MagneticQuantumNumberEnum.MQN0;

            for (int i = 0; i < 1; i++) {
                _hydrogenAtomWaveFunction.UpdateHydrogenAtomWaveFunction();
                _heatMapRenderer.Render(_hydrogenAtomWaveFunction);
            }
        }

        [TestMethod]
        public void CheckRenderingTime_4f3()
        {
            _hydrogenAtomWaveFunction.PrincipalQuantumNumber = PrincipalQuantumNumberEnum.PQN4;
            _hydrogenAtomWaveFunction.AzimuthalQuantumNumber = AzimuthalQuantumNumberEnum.AQN3;
            _hydrogenAtomWaveFunction.MagneticQuantumNumber = MagneticQuantumNumberEnum.MQN_P3;

            for (int i = 0; i < 1; i++) {
                _hydrogenAtomWaveFunction.UpdateHydrogenAtomWaveFunction();
                _heatMapRenderer.Render(_hydrogenAtomWaveFunction);
            }
        }


        [TestMethod]
        public void CheckRenderingTime_4d2()
        {
            _hydrogenAtomWaveFunction.PrincipalQuantumNumber = PrincipalQuantumNumberEnum.PQN4;
            _hydrogenAtomWaveFunction.AzimuthalQuantumNumber = AzimuthalQuantumNumberEnum.AQN2;
            _hydrogenAtomWaveFunction.MagneticQuantumNumber = MagneticQuantumNumberEnum.MQN_P2;

            for (int i = 0; i < 1; i++) {
                _hydrogenAtomWaveFunction.UpdateHydrogenAtomWaveFunction();
                _heatMapRenderer.Render(_hydrogenAtomWaveFunction);
            }
        }

        [TestMethod]
        public void CheckRenderingTime_3p1()
        {
            _hydrogenAtomWaveFunction.PrincipalQuantumNumber = PrincipalQuantumNumberEnum.PQN3;
            _hydrogenAtomWaveFunction.AzimuthalQuantumNumber = AzimuthalQuantumNumberEnum.AQN1;
            _hydrogenAtomWaveFunction.MagneticQuantumNumber = MagneticQuantumNumberEnum.MQN_P1;

            for (int i = 0; i < 1; i++) {
                _hydrogenAtomWaveFunction.UpdateHydrogenAtomWaveFunction();
                _heatMapRenderer.Render(_hydrogenAtomWaveFunction);
            }
        }

        [TestMethod]
        public void CheckRenderingTime_2p0()
        {
            _hydrogenAtomWaveFunction.PrincipalQuantumNumber = PrincipalQuantumNumberEnum.PQN2;
            _hydrogenAtomWaveFunction.AzimuthalQuantumNumber = AzimuthalQuantumNumberEnum.AQN1;
            _hydrogenAtomWaveFunction.MagneticQuantumNumber = MagneticQuantumNumberEnum.MQN0;

            for (int i = 0; i < 1; i++) {
                _hydrogenAtomWaveFunction.UpdateHydrogenAtomWaveFunction();
                _heatMapRenderer.Render(_hydrogenAtomWaveFunction);
            }
        }
    }
}
