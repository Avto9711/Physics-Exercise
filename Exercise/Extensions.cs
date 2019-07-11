using System;

namespace Exercise{
    public static class Extensions{
        public static double K = (8.99 * Math.Pow(10, 9));
        public static double KPotencialEnergy = (9 * Math.Pow(10, 9));
        public static double[] GetCoordinates(this Charge Charge){
            return Charge.Coordenadas;
        }

        public static double GetDistanceBetweenCharges(Charge from, Charge to)
            => Math.Sqrt(Math.Pow((double)from.Coordenadas[0] - (double)to.Coordenadas[0], 2) + Math.Pow((double)from.Coordenadas[1] - (double)to.Coordenadas[1], 2) + Math.Pow((double)from.Coordenadas[2] - (double)to.Coordenadas[2], 2));

        public static double GetElectricForce(this Charge charge, ElectricForceResult result ){
            return GenericPitagoraso(result.Fex,result.Fey,result.Fez);
        }

        public static double GenericPitagoraso(double firstNum, double secondNum, double thirdNum)
        {
            return Math.Sqrt(Math.Pow(firstNum, 2) + Math.Pow(secondNum, 2) + Math.Pow(thirdNum, 2));
        }

        public static void GenerateElectricCamp(this CampElectricResult campElectricResult)
        {
            campElectricResult.Ce = GenericPitagoraso(campElectricResult.Cex, campElectricResult.Cey, campElectricResult.Cez);
        }
        public static double GetValue(this Charge Charge){
            return Charge.Value * Math.Pow(10,-6);
        }
    }
}