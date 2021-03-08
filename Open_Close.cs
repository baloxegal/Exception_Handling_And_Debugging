using System;

namespace OpenClosePrinciple
{
    //Violating Open-Closed Principle + Violating Single Responsibility Principle
    abstract class Vehicle
    {
        int passangers;
        int cargo;
        public int Passangers
        {
            get
            {
                return passangers;
            }
            set
            {
                if (value >= 0)
                    passangers = value;
            }
        }
        public int Cargo
        {
            get
            {
                return cargo;
            }
            set
            {
                if (value >= 0)
                    cargo = value;
            }
        }
    }
    class PassangersVehicle : Vehicle
    {
        public PassangersVehicle(int passangers)
        {
            this.Passangers = passangers;
        }        
    }
    class CargoVehicle : Vehicle
    {
        public CargoVehicle(int cargo)
        {
            this.Cargo = cargo;
        }           
    }
    class Rout
    { 
        public static void WhatRout(Vehicle vehicle)
        {
            if(vehicle is PassangersVehicle)
                Console.WriteLine("Vehicle rout to Gara de Nord");
            else if(vehicle is CargoVehicle)
                Console.WriteLine("Vehicle rout to str. Uzinilor");           
        }
    }

    //Compliance with the Open-Closed Principle + Compliance with the Single Responsibility Principle
    abstract class CorrectVehicle
    {
        public abstract void CorrectRout();
    }
    class CorrectPassangersVehicle : CorrectVehicle
    {
        int correctPassangers;
        public CorrectPassangersVehicle(int correctPassangers)
        {
            this.correctPassangers = correctPassangers;
        }
        public int CorrectPassangers
        {
            get
            {
                return correctPassangers;
            }
            set
            {
                if (value >= 0)
                    correctPassangers = value;
            }
        }
        public override void CorrectRout()
        {
            Console.WriteLine("Vehicle rout to Gara de Sud");
        }

    }
    class CorrectCargoVehicle : CorrectVehicle
    {
        int correctCargo;
        public CorrectCargoVehicle(int correctCargo)
        {
            this.correctCargo = correctCargo;
        }
        public int CorrectCargo
        {
            get
            {
                return correctCargo;
            }
            set
            {
                if (value >= 0)
                    correctCargo = value;
            }
        }
        public override void CorrectRout()
        {
            Console.WriteLine("Vehicle rout to str. Muncesti");
        }

    }
    class CorrectClassRout
    {
        public static void ThisIsCorrectRout(CorrectVehicle correctVehicle)
        {
            correctVehicle.CorrectRout();
        }
    }
}
