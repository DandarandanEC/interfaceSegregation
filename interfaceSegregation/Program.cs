using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceSegregation
{    

    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Cleaner Interface:");
            Cleaner cleaner = new Cleaner();
            cleaner.loginForAttendance();
            cleaner.cleanFloor();
            Console.WriteLine();

            Console.WriteLine("Dishwasher Interface:");
            Dishwasher dishWasher = new Dishwasher();
            dishWasher.loginForAttendance();
            dishWasher.washDishes();
            Console.WriteLine();

            Console.WriteLine("Cook Interface:");
            Cook cook = new Cook();
            cook.loginForAttendance();
            cook.cookFood("Menudo");
            Console.WriteLine();
        }
    }    
}
