using System;
namespace Exercise
{
    public class ElectricForceResult {
        public double Fex { get; set; }
        public double Fey { get; set; }
        public double Fez { get; set; } 
        public double Fe { get; set; }
    


        public string GetResults(){
            return string.Format("FEX:{0}N, FEY:{1}N, FEZ:{2}N, FE:{3}N",this.Fex.ToString("0.00000E0"),this.Fey.ToString("0.00000E0"),this.Fez.ToString("0.00000E0"),this.Fe.ToString("0.00000E0"));
        }

    }
}
