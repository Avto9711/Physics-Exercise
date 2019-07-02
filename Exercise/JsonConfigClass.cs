using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class JsonConfigClass
    {
        public ElectricForceImport ElectricForce { get; set; }
        public ElectricCampImport ElectricCamp { get; set; }
        public PotencialEnergyImport PotencialEnergy { get; set; }
        public ElectricPotentialImport ElectricPotential { get; set; }
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
    public class PotencialEnergyImport
    {
        public Charge[] Charges { get; set; }

    }

    public class ElectricPotentialImport
    {
        public Charge[] Charges { get; set; }
        public double[] ElectricPotentialPoint { get; set; }


    }


}
