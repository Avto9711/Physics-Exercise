using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class CampElectricResult
    {
       
        private readonly Charge[] _forces;
        private readonly Charge _selectedCharge;
        public double Cex { get; set; }
        public double Cey { get; set; }
        public double Cez { get; set; }
        public double Ce { get; set; }

        public string GetResults()
        {
            return string.Format("Cex:{0}N/C, Cey:{1}N/C, Cez:{2}N/C, Ce:{3}N/C", this.Cex.ToString("0.00000E0"), this.Cey.ToString("0.00000E0"), this.Cez.ToString("0.00000E0"), this.Ce.ToString("0.00000E0"));
        }
    }
}
