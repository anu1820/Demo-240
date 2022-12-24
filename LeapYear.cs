using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class LeapYear
    {
        public static void function() 
        {
            Console.WriteLine("Enter the number to find if it is leap year or not.");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 4== 0) 
            {
                Console.WriteLine("This is a leap year");
            }
            else
            {
                Console.WriteLine("This is not a leap year");
            }

        }
    }
}
