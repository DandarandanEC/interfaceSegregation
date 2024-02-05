using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceSegregation
{
    interface IEmployee
    {
        void loginForAttendance();
    }

    interface IDishwasher
    {
        void washDishes();
    }

    interface ICleaner
    {
        void cleanFloor();
    }

    interface ICook
    {
        void cookFood(string meal);
    }
}
