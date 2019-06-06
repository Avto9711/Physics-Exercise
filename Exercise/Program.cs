using System;
using System.IO;

namespace Exercise{
public class Program
{
  public static double[] NumbersArray(double val1, double val2, double val3)=> new double[3]{val1,val2,val3};

	public static void Main()
	{

            JsonConfigClass config = Newtonsoft.Json.JsonConvert.DeserializeObject<JsonConfigClass>(File.ReadAllText(Environment.CurrentDirectory + "/Inputs.json"));
            var electricForceConfig = config.ElectricForce;
            var electricCampConfig = config.ElectricCamp;
            //Charge[] charges = new Charge[8]
            //{

            //    new Charge{Nombre="Q1",Value=2,Coordenadas=NumbersArray(0,0,0)},
            //    new Charge{Nombre="Q2", Value=1.5, Coordenadas=NumbersArray(0,0,0.45)},
            //    new Charge{Nombre="Q3", Value=3, Coordenadas=NumbersArray(0.8,0,0.45)},
            //    new Charge{Nombre="Q4", Value=-3.5, Coordenadas=NumbersArray(0.8,0,0)},
            //    new Charge{Nombre="Q5", Value=7, Coordenadas=NumbersArray(0.8,0.6,0)},
            //    new Charge{Nombre="Q6", Value=-2, Coordenadas=NumbersArray(0,0.6,0)},
            //    new Charge{Nombre="Q7", Value=1, Coordenadas=NumbersArray(0,0.6,0.45)},
            //    new Charge{Nombre="Q8", Value=-1, Coordenadas=NumbersArray(0.8,0.6,0.45)},

            //};
            ElectricForce calc = new ElectricForce(electricForceConfig.Charges,
                electricForceConfig.Charges[electricForceConfig.SelectedChargeIndex]);

            ElectricCamp ecamp = new ElectricCamp(electricCampConfig.Charges);

            Console.WriteLine("--Fuerza Electrica--");
            Console.WriteLine(calc.Calculate().GetResults());
            Console.WriteLine("--Campo Electrico--");
            Console.WriteLine(ecamp.Calculate(electricCampConfig.ElectricChargePoints).GetResults());
            Console.ReadKey();
        }
    } 
}