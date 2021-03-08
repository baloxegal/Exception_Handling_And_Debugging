using System;

namespace Interface_Segregation
{
    //Violating Interface Substitution Principle
    interface INotInterfaceSegregatedMoveable
    {
        void MoveRight();
        void MoveLeft();
        void MoveForward();
        void MoveBack();
        void MoveUp(); //only for flaying vehicles(passangers vehicles)
        void MoveDown(); //only for flaying vehicles(passangers vehicles)
    }
    abstract class NotInterfaceSegregatedVehicle
    {
        public abstract void NotInterfaceSegregatedRout();
    }
    class NotInterfaceSegregatedPassangersVehicle : NotInterfaceSegregatedVehicle, INotInterfaceSegregatedMoveable
    {
        int correctPassangers;
        public NotInterfaceSegregatedPassangersVehicle(int correctPassangers)
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
        public override void NotInterfaceSegregatedRout()
        {
            MoveUp();
            Console.WriteLine("Your Vehicle is flying to Gara de Donduseni");
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
            Console.Write("Your Vehicle is hop of from earth. ");
        }
        public void MoveDown()
        {
            //some code
        }
    }
    class NotInterfaceSegregatedCargoVehicle : NotInterfaceSegregatedVehicle, INotInterfaceSegregatedMoveable
    {
        int correctCargo;
        public NotInterfaceSegregatedCargoVehicle(int correctCargo)
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
        public override void NotInterfaceSegregatedRout()
        {
            MoveUp();            
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

        public void MoveUp()//redundant methods for this class
        {
            Console.WriteLine("Redundant methods for this class");
        }
        public void MoveDown()//redundant methods for this class
        {
            Console.WriteLine("Redundant methods for this class");
        }
    }
    class NotInterfaceSegregatedRout
    {
        public static void ThisIsNotInterfaceSegregatedRout(NotInterfaceSegregatedVehicle correctVehicle)
        {
            correctVehicle.NotInterfaceSegregatedRout();
        }
    }

    //Compliance with the Interface Substitution Principle
    interface ICorrectMoveable
    {
        void MoveRight();
        void MoveLeft();
        void MoveForward();
        void MoveBack();        
    }
    interface IFlyable : ICorrectMoveable
    {
        void MoveUp();
        void MoveDown();
    }
    abstract class InterfaceSegregatedVehicle
    {
        public abstract void InterfaceSegregatedRout();
    }
    class InterfaceSegregatedPassangersVehicle : InterfaceSegregatedVehicle, IFlyable
    {
        int correctPassangers;
        public InterfaceSegregatedPassangersVehicle(int correctPassangers)
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
        public override void InterfaceSegregatedRout()
        {
            MoveUp();
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
    class InterfaceSegregatedCargoVehicle : InterfaceSegregatedVehicle, ICorrectMoveable
    {
        int correctCargo;
        public InterfaceSegregatedCargoVehicle(int correctCargo)
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
        public override void InterfaceSegregatedRout()
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
    class InterfaceSegregatedRout
    {
        public static void ThisIsInterfaceSegregatedRout(InterfaceSegregatedVehicle correctVehicle)
        {
            correctVehicle.InterfaceSegregatedRout();
        }
    }
}
