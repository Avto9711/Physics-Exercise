using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
   public class ElectricCamp
    {

        private readonly Charge[] _forces;
      

        public ElectricCamp(Charge[] charges)
        {
            _forces = charges;
        }
        public CampElectricResult Calculate(double[] pointToCalculate)
        {
            var electricCamp = new CampElectricResult();

            for (int i = 0; i < _forces.Length; i++)
            {
                var currentCharge = _forces[i];
                var currentChargeCords = currentCharge.GetCoordinates();
                var currentChargeValue = currentCharge.GetValue();
                var distanceBetweenCharges = Extensions.GetDistanceBetweenCharges(currentCharge, new Charge { Coordenadas = pointToCalculate });

                if (distanceBetweenCharges is 0)
                {
                    Console.WriteLine("2 o mas cargas no pueden estar en la misma posicion");
                    return electricCamp;
                }

                electricCamp.Cex += ((currentChargeValue / Math.Pow(distanceBetweenCharges, 3)) * (pointToCalculate[0] - currentChargeCords[0]));
                electricCamp.Cey += ((currentChargeValue / Math.Pow((double)distanceBetweenCharges, 3)) * (pointToCalculate[1] - currentChargeCords[1]));
                electricCamp.Cez += ((currentChargeValue / Math.Pow((double)distanceBetweenCharges, 3)) * (pointToCalculate[2] - currentChargeCords[2]));

            }

            electricCamp.Cex *= Extensions.K;
            electricCamp.Cey *= Extensions.K;
            electricCamp.Cez *= Extensions.K;

            electricCamp.GenerateElectricCamp();

            return electricCamp;
        }
    }
}
