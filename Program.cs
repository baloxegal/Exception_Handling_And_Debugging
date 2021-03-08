using System;

namespace Exception_Handling_And_Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            //Violating Open-Closed Principle + Violating Single Responsibility Principle
            OpenClosePrinciple
            OpenVehicle passangersVehicle = new PassangersVehicle(40);
            Vehicle cargoVehicle = new CargoVehicle(5000);
            Rout.WhatRout(passangersVehicle);
            Rout.WhatRout(cargoVehicle);
            Console.WriteLine();

            //Compliance with the Open-Closed Principle + Compliance with the Single Responsibility Principle
            CorrectVehicle correctPassangersVehicle = new CorrectPassangersVehicle(60);
            CorrectVehicle correctCargoVehicle = new CorrectCargoVehicle(10000);
            CorrectClassRout.ThisIsCorrectRout(correctPassangersVehicle);
            CorrectClassRout.ThisIsCorrectRout(correctCargoVehicle);
            Console.WriteLine();

            //Violating Liscov Substitution Principle
            NotLiscovPassangersVehicle notLiscovPassangersVehicle = new NotLiscovPassangersVehicle(100);
            NotLiscovCargoVehicle notLiscovCargoVehicle = new NotLiscovCargoVehicle(15000);
            NotLiscovRout.NotLiscovPassangersRout(notLiscovPassangersVehicle);
            NotLiscovRout.NotLiscovCargoRout(notLiscovCargoVehicle);
            Console.WriteLine();

            //Compliance with the Liscov Substitution Principle
            LiscovVehicle liscovPassangersVehicle = new LiscovPassangersVehicle(10);
            LiscovVehicle liscovCargoVehicle = new LiscovCargoVehicle(20000);
            LiscovRout.ThisIsLiscovRout(liscovPassangersVehicle);
            LiscovRout.ThisIsLiscovRout(liscovCargoVehicle);
            Console.WriteLine();

            //Violating Interface Substitution Principle
            NotInterfaceSegregatedVehicle notInterfaceSegregatedPassangersVehicle = new NotInterfaceSegregatedPassangersVehicle(10);
            NotInterfaceSegregatedVehicle notInterfaceSegregatedCargoVehicle = new NotInterfaceSegregatedCargoVehicle(3500);
            NotInterfaceSegregatedRout.ThisIsNotInterfaceSegregatedRout(notInterfaceSegregatedPassangersVehicle);
            NotInterfaceSegregatedRout.ThisIsNotInterfaceSegregatedRout(notInterfaceSegregatedCargoVehicle);
            Console.WriteLine();

            //Compliance with the Interface Substitution Principle
            InterfaceSegregatedVehicle interfaceSegregatedPassangersVehicle = new InterfaceSegregatedPassangersVehicle(12);
            InterfaceSegregatedVehicle interfaceSegregatedCargoVehicle = new InterfaceSegregatedCargoVehicle(6000);
            InterfaceSegregatedRout.ThisIsInterfaceSegregatedRout(interfaceSegregatedPassangersVehicle);
            InterfaceSegregatedRout.ThisIsInterfaceSegregatedRout(interfaceSegregatedCargoVehicle);
        }
    }
}
