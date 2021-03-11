using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles_Routs
{
    class WrongArgument : Exception
    {
        public WrongArgument(string message) : base(message)
        {
            
        }
    }
}
