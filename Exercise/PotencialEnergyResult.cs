using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise
{
    public class PotencialEnergyResult
    {
        public PotencialEnergyResult()
        {
            this.Values = new List<double>();
        }
        public string Result { get {
                return (this.Values.Aggregate(
                    
                    (val, val2) => (val + val2)
                    
                    
                    ) * Extensions.KPotencialEnergy).ToString("0.00E0");
            }
        }
        public List<double> Values { get; set; }
    }
}
