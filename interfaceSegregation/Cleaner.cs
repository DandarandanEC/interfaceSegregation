using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceSegregation
{
    public class Cleaner : IEmployee, ICleaner
    {
        public void loginForAttendance()
        {
            Console.WriteLine("Cleaner In!");
        }

        public void cleanFloor()
        {
            Console.WriteLine("I will now clean the floors!");
        }
    }
}
