using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceSegregation
{
    public class Dishwasher : IEmployee, IDishwasher
    {
        public void loginForAttendance()
        {
            Console.WriteLine("Dishwasher In!");
        }

        public void washDishes()
        {
            Console.WriteLine("I will now wash the dishes!");
        }
    }
}
