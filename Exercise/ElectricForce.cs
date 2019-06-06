using System;

namespace Exercise{
    public class ElectricForce{


	    private readonly Charge[] _forces;
	    private readonly Charge _selectedCharge;
        public ElectricForce(Charge[] charges, Charge selectedCharge){
            _forces = charges;
           _selectedCharge =  selectedCharge;
        }



        public ElectricForceResult Calculate(){
                var selectedChargeCords = _selectedCharge.GetCoordinates();
                var selectedChargeValue = _selectedCharge.GetValue();
                var absSelectedCharge = Math.Abs(selectedChargeValue);                            
                var result = new ElectricForceResult();


                for(var i=0; i<_forces.Length; i++){
                    var currentCharge = _forces[i];
                    if(currentCharge.Nombre == _selectedCharge.Nombre)
                        continue;

                    var currentChargeCords = currentCharge.GetCoordinates();
                    var currentChargeValue = currentCharge.GetValue();
                    var distanceBetweenCharges = Extensions.GetDistanceBetweenCharges(currentCharge, _selectedCharge);
                    var absCurrentChargeValue = Math.Abs(currentCharge.GetValue());
                if (distanceBetweenCharges is 0)
                {
                    Console.WriteLine("2 o mas cargas no pueden estar en la misma posicion");
                    return result;
                }
                            

                    var isGetAttracted = (currentChargeValue * selectedChargeValue) < 0;
                    result.Fex += ((absCurrentChargeValue/Math.Pow(distanceBetweenCharges, 3)) * (selectedChargeCords[0] - currentChargeCords[0])) * (isGetAttracted ? -1 : 1);

                    result.Fey += ((absCurrentChargeValue / Math.Pow((double)distanceBetweenCharges, 3)) * (selectedChargeCords[1] - currentChargeCords[1])) * (isGetAttracted ? -1 : 1);
                    result.Fez += ((absCurrentChargeValue / Math.Pow((double)distanceBetweenCharges, 3)) * (selectedChargeCords[2] - currentChargeCords[2])) * (isGetAttracted ? -1 : 1);
                }

                var common = Extensions.K * absSelectedCharge;
                result.Fex *= common;
                result.Fey *= common;
                result.Fez *= common;
                result.Fe = _selectedCharge.GetElectricForce(result);

                return result;

        }

    }
}