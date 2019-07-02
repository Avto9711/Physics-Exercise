using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class PotencialEnergy
    {
        private readonly Charge[] _forces;

        public PotencialEnergy(Charge[] charges)
        {
            this._forces = charges;
        }

        public PotencialEnergyResult Calculate()
        {
            var result = new PotencialEnergyResult();

            for (int i = 0; i < this._forces.Length; i++)
            {
                var firstCharge = this._forces[i];
                var coordanadasCargaActual = firstCharge.GetCoordinates();
                var valorCargaActual = firstCharge.GetCoordinates();

                for (int y = 0; y < this._forces.Length; y++)
                {
                    if (i != y && i > y)
                    {
                        var secondCharge = this._forces[y];

                        var coordenadaCargaHermana = secondCharge.GetCoordinates();
                        var valorCargaHermana = secondCharge.GetValue();
                        var distance = Extensions.GetDistanceBetweenCharges(firstCharge, secondCharge);

                        result.Values.Add((valorCargaHermana * valorCargaHermana)/distance);

                    }
                }

            }
            return result; 
        }

    }
}
