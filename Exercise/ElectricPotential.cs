using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class ElectricPotential
    {
        private readonly Charge[] _forces;


        public ElectricPotential(Charge[] charges)
        {
            this._forces = charges;

        }

        public ElectricPotentialResult Calculate(double[] pointToCalculate)
        {
            var result = new ElectricPotentialResult();
            for (int i = 0; i < this._forces.Length; i++)
            {
                var currentCharge = _forces[i];
                var currentChargeCords = currentCharge.GetCoordinates();
                var currentChargeValue = currentCharge.GetValue();
                var distanceBetweenCharges = Extensions.GetDistanceBetweenCharges(currentCharge, new Charge { Coordenadas = pointToCalculate });

                if (distanceBetweenCharges is 0)
                {
                    Console.WriteLine("2 o mas cargas no pueden estar en la misma posicion");
                    return result;
                }

                var calcule = currentCharge.GetValue() / distanceBetweenCharges;

                result.Values.Add(calcule);
            }

            return result;
        }
    }
}
