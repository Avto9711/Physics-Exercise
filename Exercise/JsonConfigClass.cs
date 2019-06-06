using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class JsonConfigClass
    {
        public ElectricForceImport ElectricForce { get; set; }
        public ElectricCampImport ElectricCamp { get; set; }
    }

    public class ElectricForceImport
    {
        public Charge[] Charges { get; set; }
        public int SelectedChargeIndex { get; set; }
    }

    public class ElectricCampImport
    {
        public Charge[] Charges { get; set; }
        public double[] ElectricChargePoints { get; set; }
    }
}
