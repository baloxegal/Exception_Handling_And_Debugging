using System;

namespace Vehicles_Routs
{
    interface IFlyable : IMoveable
    {
        void MoveUp();
        void MoveDown();
    }
}
