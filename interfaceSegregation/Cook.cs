using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceSegregation
{
    public class Cook : IEmployee, ICook
    {        
        public void loginForAttendance()
        {
            Console.WriteLine("Cook In!");
        }

        public void cookFood(string meal)
        {
            Console.WriteLine($"I will now cook {meal}!");
        }
    }
}
