using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise
{
    public class ElectricPotentialResult
    {
        public ElectricPotentialResult()
        {
            this.Values = new List<double>();
        }
        public string Result
        {
            get
            {
                return (this.Values.Aggregate((val, val2) => (val + val2)) * Extensions.K).ToString("0.00000E0");
            }
        }
        public List<double> Values { get; set; }
    }
}
