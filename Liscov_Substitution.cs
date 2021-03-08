using System;

namespace Liscov_Substitution
{
    //Violating Liscov Substitution Principle
    class NotLiscovPassangersVehicle
    {
        int notLiscovPassangers;
        public NotLiscovPassangersVehicle(int passangers)
        {
            this.notLiscovPassangers = passangers;
        }
        public int NotLiscovPassangers
        {
            get
            {
                return notLiscovPassangers;
            }
            set
            {
                if (value >= 0)
                    notLiscovPassangers = value;
            }
        }
    }
    class NotLiscovCargoVehicle
    {
        int notLiscovCargo;
        public NotLiscovCargoVehicle(int cargo)
        {
            this.notLiscovCargo = cargo;
        }
        public int NotLiscovCargo
        {
            get
            {
                return notLiscovCargo;
            }
            set
            {
                if (value >= 0)
                    notLiscovCargo = value;
            }
        }
    }
    class NotLiscovRout
    {
        public static void NotLiscovPassangersRout(NotLiscovPassangersVehicle vehicle)
        {
            Console.WriteLine("Vehicle rout to Gara Balti");
        }
        public static void NotLiscovCargoRout(NotLiscovCargoVehicle vehicle)
        {
            Console.WriteLine("Vehicle rout to str. Petricani");            
        }
    }

    //Compliance with the Liscov Substitution Principle
    abstract class LiscovVehicle
    {
        public abstract void LiscovRout();
    }
    class LiscovPassangersVehicle : LiscovVehicle
    {
        int correctPassangers;
        public LiscovPassangersVehicle(int correctPassangers)
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
        public override void LiscovRout()
        {
            Console.WriteLine("Vehicle rout to Gara de Cahul");
        }

    }
    class LiscovCargoVehicle : LiscovVehicle
    {
        int correctCargo;
        public LiscovCargoVehicle(int correctCargo)
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
        public override void LiscovRout()
        {
            Console.WriteLine("Vehicle rout to str. Muncesti");
        }

    }
    class LiscovRout
    {
        public static void ThisIsLiscovRout(LiscovVehicle correctVehicle)
        {
            correctVehicle.LiscovRout();
        }
    }
}
