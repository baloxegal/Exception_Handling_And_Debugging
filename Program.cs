using System;

namespace Exception_Handling_And_Debugging
{
    using Vehicles_Routs;
    class Program
    {
        static void Main(string[] args)
        {            
            var p = Console.ReadLine();
            int.TryParse(p, out int a);            
            Vehicle passangersVehicle = new PassangersVehicle(a);            
            Vehicle cargoVehicle = new CargoVehicle(5000);
            Rout.GetRout(passangersVehicle, 30);
            Rout.GetRout(cargoVehicle, 3000);                        
        }
    }
}
