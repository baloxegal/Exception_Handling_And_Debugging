using System;

namespace Vehicles_Routs
{
    class Rout
    {
        int carry;        
        public void GetRout(Vehicle vehicle, object whatCarry)
        {
            while (true)
            {               
                try
                {
                    if (whatCarry == null)
                    {
                        throw new ArgumentNullException("This is a object with null, yet");
                    }
                    if (whatCarry.Equals("repeat"))
                    {
                        Console.WriteLine("Enter correct value of carry");
                        int.TryParse(Console.ReadLine(), out int c);
                        whatCarry = c;
                    }

                    var wc = (int)whatCarry;     //InvalidCastException               
                    if (vehicle is PassangersVehicle)
                    {
                        var v = vehicle as PassangersVehicle;
                        if (wc > v.SeatPlaces)
                            throw new ArgumentOutOfRangeException($"This car doesn't have that many seats, max {v.SeatPlaces} seats");
                        else if (wc < 0)
                            throw new ArgumentOutOfRangeException("You entered the wrong number of passangers, that dosn't may be less than 0");
                        else
                        {
                            carry = wc;
                            break;
                        }                            
                    }
                    else if (vehicle is CargoVehicle)
                    {
                        var v = vehicle as CargoVehicle;
                        if (wc > v.CarryingCapacity)
                            throw new WrongArgument($"This car doesn't have that carrying capacity, max - {v.CarryingCapacity} kg");
                        else if (wc < 0)
                            throw new WrongArgument("You entered the wrong size of carryin kg, that dosn't may be less than 0");
                        else
                        {
                            carry = wc;
                            break;
                        }
                            
                    }
                }                
                catch (ArgumentOutOfRangeException a)
                {
                    Console.WriteLine($"Error: {a}");
                    if ((int)whatCarry > ((PassangersVehicle)vehicle).SeatPlaces)
                        carry = ((PassangersVehicle)vehicle).SeatPlaces;
                    else if ((int)whatCarry < 0)
                        carry = 0;
                    Console.WriteLine(carry);
                    break;
                }
                catch (InvalidCastException i)
                {
                    Console.WriteLine($"Error: {i}");
                    whatCarry = null;
                    //throw new ArgumentNullException("New attempt to get a right argument");
                    //throw;
                    throw new Exception("Total problem");
                }
                catch(WrongArgument w)
                {
                    Console.WriteLine(w);
                    if ((int)whatCarry > ((CargoVehicle)vehicle).CarryingCapacity)
                        carry = ((CargoVehicle)vehicle).CarryingCapacity;
                    else if ((int)whatCarry < 0)
                        carry = 0;
                    Console.WriteLine(carry);
                    break;
                }
                catch (ArgumentNullException n)
                {
                    Console.WriteLine($"{n.StackTrace}; {n.GetType()}; {n.Message}");
                    whatCarry = "repeat";
                }
            }
            vehicle.Rout((int)whatCarry);
        }
    }
}
