using System;

namespace Vehicles_Routs
{
    abstract class Vehicle
    {
        public abstract void Rout(int whatCarry);
    }
    class PassangersVehicle : Vehicle, IFlyable
    {        
        public PassangersVehicle(int seatPlaces)
        {
            try
            {
                if (seatPlaces <= 0 || seatPlaces > 100)
                    throw new ArgumentOutOfRangeException("Quantity of passangers can't be more than 100 or less or equal than 0");
                else
                    SeatPlaces = seatPlaces;                
            }
            catch (ArgumentOutOfRangeException a)
            {
                Console.WriteLine($"Error: {a}");
            }
            finally
            {
                if (seatPlaces <= 0 || seatPlaces > 100)
                {
                    SeatPlaces = 1;
                    Console.WriteLine(SeatPlaces);
                }               
            }           
        }
        public int SeatPlaces
        {
            get;
            set;    
        }
        public override void Rout(int whatCarry)
        {
            Console.WriteLine("Your Vehicle is flying to Gara de Tiraspol");
        }

        public void MoveBack()
        {            
            //some code
        }

        public void MoveForward()
        {
            //some code
        }

        public void MoveLeft()
        {
            //some code
        }

        public void MoveRight()
        {
            //some code
        }
        public void MoveUp()
        {
            //some code
        }
        public void MoveDown()
        {
            //some code
        }
    }
    class CargoVehicle : Vehicle, IMoveable
    {        
        public CargoVehicle(int carryingCapacity)
        {
            CarryingCapacity = carryingCapacity;
        }
        public int CarryingCapacity
        {
            get;
            set;            
        }
        public override void Rout(int whatCarry)
        {
            Console.WriteLine("Vehicle rout to str. Voluntarilor");
        }

        public void MoveBack()
        {
            //some code
        }

        public void MoveForward()
        {
            //some code
        }

        public void MoveLeft()
        {
            //some code
        }

        public void MoveRight()
        {
            //some code
        }
    }
}
