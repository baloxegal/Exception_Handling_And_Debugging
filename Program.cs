#define DEBUG
#define InvalidCastException
#define ArgumentNullException
#undef DEBUG
#undef InvalidCastException
//#undef ArgumentNullException
using System;

namespace Exception_Handling_And_Debugging
{
    using Vehicles_Routs;
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var a = int.Parse(Console.ReadLine());
                Vehicle passangersVehicle = new PassangersVehicle(a);// For FormatException frown by comp

                var r1 = new Rout();
#if (DEBUG)
                int.TryParse(Console.ReadLine(), out int b);
#elif (ArgumentNullException)
                string b = null; // For ArgumentNullException
#endif
#if (DEBUG || ArgumentNullException)
                r1.GetRout(passangersVehicle, b);
#endif
#if (InvalidCastException)
                r1.GetRout(passangersVehicle, Console.ReadLine()); //For InvalidCastException
#endif
                bool y = int.TryParse(Console.ReadLine(), out int c);
                if (y == false)
                    throw new FormatException("Exception throwed by me");
                Vehicle cargoVehicle = new CargoVehicle(c);

                int.TryParse(Console.ReadLine(), out int d);
                var r2 = new Rout();
                r2.GetRout(cargoVehicle, d);
            }
            catch (FormatException f) when (f.Message.Contains("Exception throwed by me"))
            {                    
                Console.WriteLine($"{f}; This is a big problem with format and it throwed by me"); 
            }
            catch (FormatException f)
            {
                Console.WriteLine($"{f}; This is a big problem with format");
            }
            catch (ArgumentNullException a)
            {
                Console.WriteLine($"{a}; This is a big problem with null");
            }
            catch (InvalidCastException a)
            {
                Console.WriteLine($"{a}; This is a big problem with cast");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e}; This is a big problem with all");
            }
        }
    }
}
