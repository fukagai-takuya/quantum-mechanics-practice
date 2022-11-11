using System;

namespace HydrogenAtomSchrodinger.Models
{
    public class HydrogenAtomWaveFunction
    {
        private Func<double, double, double> GetProbabilityDensityFromRTheta { get; set; } = (r, theta) => GetRSquared_1s(r) * GetYSquared_s(theta);

        public PrincipalQuantumNumberEnum PrincipalQuantumNumber = PrincipalQuantumNumberEnum.PQN1;
        public AzimuthalQuantumNumberEnum AzimuthalQuantumNumber = AzimuthalQuantumNumberEnum.AQN0;
        public MagneticQuantumNumberEnum MagneticQuantumNumber = MagneticQuantumNumberEnum.MQN0;

        public void UpdateHydrogenAtomWaveFunction()
        {
            if (PrincipalQuantumNumber == PrincipalQuantumNumberEnum.PQN1)
            {
                GetProbabilityDensityFromRTheta = (r, theta) => GetRSquared_1s(r) * GetYSquared_s(theta);
            }
            else if (PrincipalQuantumNumber == PrincipalQuantumNumberEnum.PQN2)
            {
                if (AzimuthalQuantumNumber == AzimuthalQuantumNumberEnum.AQN0)
                {
                    GetProbabilityDensityFromRTheta = (r, theta) => GetRSquared_2s(r) * GetYSquared_s(theta);
                }
                else if (AzimuthalQuantumNumber == AzimuthalQuantumNumberEnum.AQN1)
                {
                    if (MagneticQuantumNumber == MagneticQuantumNumberEnum.MQN0)
                    {
                        GetProbabilityDensityFromRTheta = (r, theta) => GetRSquared_2p(r) * GetYSquared_p0(theta);
                    }
                    else if (MagneticQuantumNumber == MagneticQuantumNumberEnum.MQN_N1 || MagneticQuantumNumber == MagneticQuantumNumberEnum.MQN_P1)
                    {
                        GetProbabilityDensityFromRTheta = (r, theta) => GetRSquared_2p(r) * GetYSquared_p1(theta);
                    }
                }
            }
            else if (PrincipalQuantumNumber == PrincipalQuantumNumberEnum.PQN3)
            {
                if (AzimuthalQuantumNumber == AzimuthalQuantumNumberEnum.AQN0)
                {
                    GetProbabilityDensityFromRTheta = (r, theta) => GetRSquared_3s(r) * GetYSquared_s(theta);
                }
                else if (AzimuthalQuantumNumber == AzimuthalQuantumNumberEnum.AQN1)
                {
                    if (MagneticQuantumNumber == MagneticQuantumNumberEnum.MQN0)
                    {
                        GetProbabilityDensityFromRTheta = (r, theta) => GetRSquared_3p(r) * GetYSquared_p0(theta);
                    }
                    else if (MagneticQuantumNumber == MagneticQuantumNumberEnum.MQN_N1 || MagneticQuantumNumber == MagneticQuantumNumberEnum.MQN_P1)
                    {
                        GetProbabilityDensityFromRTheta = (r, theta) => GetRSquared_3p(r) * GetYSquared_p1(theta);
                    }
                }
                else if (AzimuthalQuantumNumber == AzimuthalQuantumNumberEnum.AQN2)
                {
                    if (MagneticQuantumNumber == MagneticQuantumNumberEnum.MQN0)
                    {
                        GetProbabilityDensityFromRTheta = (r, theta) => GetRSquared_3d(r) * GetYSquared_d0(theta);
                    }
                    else if (MagneticQuantumNumber == MagneticQuantumNumberEnum.MQN_N1 || MagneticQuantumNumber == MagneticQuantumNumberEnum.MQN_P1)
                    {
                        GetProbabilityDensityFromRTheta = (r, theta) => GetRSquared_3d(r) * GetYSquared_d1(theta);
                    }
                    else if (MagneticQuantumNumber == MagneticQuantumNumberEnum.MQN_N2 || MagneticQuantumNumber == MagneticQuantumNumberEnum.MQN_P2)
                    {
                        GetProbabilityDensityFromRTheta = (r, theta) => GetRSquared_3d(r) * GetYSquared_d2(theta);
                    }
                }
            }
            else if (PrincipalQuantumNumber == PrincipalQuantumNumberEnum.PQN4)
            {
                if (AzimuthalQuantumNumber == AzimuthalQuantumNumberEnum.AQN0)
                {
                    GetProbabilityDensityFromRTheta = (r, theta) => GetRSquared_4s(r) * GetYSquared_s(theta);
                }
                else if (AzimuthalQuantumNumber == AzimuthalQuantumNumberEnum.AQN1)
                {
                    if (MagneticQuantumNumber == MagneticQuantumNumberEnum.MQN0)
                    {
                        GetProbabilityDensityFromRTheta = (r, theta) => GetRSquared_4p(r) * GetYSquared_p0(theta);
                    }
                    else if (MagneticQuantumNumber == MagneticQuantumNumberEnum.MQN_N1 || MagneticQuantumNumber == MagneticQuantumNumberEnum.MQN_P1)
                    {
                        GetProbabilityDensityFromRTheta = (r, theta) => GetRSquared_4p(r) * GetYSquared_p1(theta);
                    }
                }
                else if (AzimuthalQuantumNumber == AzimuthalQuantumNumberEnum.AQN2)
                {
                    if (MagneticQuantumNumber == MagneticQuantumNumberEnum.MQN0)
                    {
                        GetProbabilityDensityFromRTheta = (r, theta) => GetRSquared_4d(r) * GetYSquared_d0(theta);
                    }
                    else if (MagneticQuantumNumber == MagneticQuantumNumberEnum.MQN_N1 || MagneticQuantumNumber == MagneticQuantumNumberEnum.MQN_P1)
                    {
                        GetProbabilityDensityFromRTheta = (r, theta) => GetRSquared_4d(r) * GetYSquared_d1(theta);
                    }
                    else if (MagneticQuantumNumber == MagneticQuantumNumberEnum.MQN_N2 || MagneticQuantumNumber == MagneticQuantumNumberEnum.MQN_P2)
                    {
                        GetProbabilityDensityFromRTheta = (r, theta) => GetRSquared_4d(r) * GetYSquared_d2(theta);
                    }
                }
                else if (AzimuthalQuantumNumber == AzimuthalQuantumNumberEnum.AQN3)
                {
                    if (MagneticQuantumNumber == MagneticQuantumNumberEnum.MQN0)
                    {
                        GetProbabilityDensityFromRTheta = (r, theta) => GetRSquared_4f(r) * GetYSquared_f0(theta);
                    }
                    else if (MagneticQuantumNumber == MagneticQuantumNumberEnum.MQN_N1 || MagneticQuantumNumber == MagneticQuantumNumberEnum.MQN_P1)
                    {
                        GetProbabilityDensityFromRTheta = (r, theta) => GetRSquared_4f(r) * GetYSquared_f1(theta);
                    }
                    else if (MagneticQuantumNumber == MagneticQuantumNumberEnum.MQN_N2 || MagneticQuantumNumber == MagneticQuantumNumberEnum.MQN_P2)
                    {
                        GetProbabilityDensityFromRTheta = (r, theta) => GetRSquared_4f(r) * GetYSquared_f2(theta);
                    }
                    else if (MagneticQuantumNumber == MagneticQuantumNumberEnum.MQN_N3 || MagneticQuantumNumber == MagneticQuantumNumberEnum.MQN_P3)
                    {
                        GetProbabilityDensityFromRTheta = (r, theta) => GetRSquared_4f(r) * GetYSquared_f3(theta);
                    }
                }
            }

            if (GetProbabilityDensityFromRTheta == null)
            {
                throw new NotImplementedException($"Unsupported PrincipalQuantumNumber = {PrincipalQuantumNumber}, AzimuthalQuantumNumber = {AzimuthalQuantumNumber}, MagneticQuantumNumber = {MagneticQuantumNumber}");
            }
        }


        public double GetProbabilityDensityFromXZ(double x, double z)
        {
            double r = Math.Sqrt(x * x + z * z);
            double theta = Math.Atan2(x, z);
            return GetProbabilityDensityFromRTheta(r, theta);
        }


        private static double GetRSquared_1s(double r)
        {
            return 4 * Math.Exp(-2 * r);
        }

        private static double GetRSquared_2s(double r)
        {
            return (2 - r) * (2 - r) * Math.Exp(-r) / 8.0;
        }

        private static double GetRSquared_2p(double r)
        {
            return r * r * Math.Exp(-r) / 24.0;
        }

        private static double GetRSquared_3s(double r)
        {
            double fr = (27 - 18 * r + 2 * r * r) / 27.0;
            return 4 / 27.0 * fr * fr * Math.Exp(-2 * r / 3.0);
        }

        private static double GetRSquared_3p(double r)
        {
            double fr = r * (6 - r) / 6.0;
            return 64 / (27.0 * 27 * 6) * fr * fr * Math.Exp(-2 * r / 3.0);
        }

        private static double GetRSquared_3d(double r)
        {
            double fr = r * r;
            return 16 / (81.0 * 81 * 30) * fr * fr * Math.Exp(-2 * r / 3.0);
        }

        private static double GetRSquared_4s(double r)
        {
            double fr = (192 - 144 * r + 24 * r * r - r * r * r) / 192.0;
            return 1 / 4.0 * fr * fr * Math.Exp(-r / 2.0);
        }

        private static double GetRSquared_4p(double r)
        {
            double fr = r * (80 - 20.0 * r + r * r) / 80.0;
            return 5 / (16.0 * 16 * 3) * fr * fr * Math.Exp(-r / 2.0);
        }

        private static double GetRSquared_4d(double r)
        {
            double fr = r * r * (12 - r) / 12.0;
            return 1 / (64.0 * 64 * 5) * fr * fr * Math.Exp(-r / 2.0);
        }

        private static double GetRSquared_4f(double r)
        {
            double fr = r * r * r;
            return 1 / (768.0 * 768 * 35) * fr * fr * Math.Exp(-r / 2.0);
        }


        private static double GetYSquared_s(double theta)
        {
            return 1 / (4.0 * Math.PI);
        }

        private static double GetYSquared_p0(double theta)
        {
            double cos_th = Math.Cos(theta);
            return 3 / (4.0 * Math.PI) * cos_th * cos_th;
        }

        private static double GetYSquared_p1(double theta)
        {
            double sin_th = Math.Sin(theta);
            return 3 / (8.0 * Math.PI) * sin_th * sin_th;
        }

        private static double GetYSquared_d0(double theta)
        {
            double cos_th = Math.Cos(theta);
            double f_cos_th = 3 * cos_th * cos_th - 1;
            return 5 / (16.0 * Math.PI) * f_cos_th * f_cos_th;
        }

        private static double GetYSquared_d1(double theta)
        {
            double sin_th = Math.Sin(theta);
            double cos_th = Math.Cos(theta);
            double f_th = sin_th * cos_th;
            return 15 / (8.0 * Math.PI) * f_th * f_th;
        }

        private static double GetYSquared_d2(double theta)
        {
            double sin_th = Math.Sin(theta);
            double f_sin_th = sin_th * sin_th;
            return 15 / (32.0 * Math.PI) * f_sin_th * f_sin_th;
        }

        private static double GetYSquared_f0(double theta)
        {
            double cos_th = Math.Cos(theta);
            double f_cos_th = 5 * cos_th * cos_th * cos_th - 3 * cos_th;
            return 7 / (16.0 * Math.PI) * f_cos_th * f_cos_th;
        }

        private static double GetYSquared_f1(double theta)
        {
            double sin_th = Math.Sin(theta);
            double cos_th = Math.Cos(theta);
            double f_th = (5 * cos_th * cos_th - 1) * sin_th;
            return 21 / (64.0 * Math.PI) * f_th * f_th;
        }

        private static double GetYSquared_f2(double theta)
        {
            double sin_th = Math.Sin(theta);
            double cos_th = Math.Cos(theta);
            double f_th = cos_th * sin_th * sin_th;
            return 105 / (32.0 * Math.PI) * f_th * f_th;
        }

        private static double GetYSquared_f3(double theta)
        {
            double sin_th = Math.Sin(theta);
            double f_sin_th = sin_th * sin_th * sin_th;
            return 35 / (64.0 * Math.PI) * f_sin_th * f_sin_th;
        }
    }
}
