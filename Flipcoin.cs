using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Flipcoin
    {

        public static void CalculatePercentage()
        {
            int headCount = 0;
            int tailCount = 0;
            double headpercentage = 0.0;
            double tailpercentage = 0.0;

            Console.WriteLine("Please enter thhe value for number of flip");
            int flip = Convert.ToInt32(Console.ReadLine()); 

            if(flip>0)
            {
                for(int i=0; i<flip; i++) 
                {
                    Random obje= new Random();

                    int number = obje.Next(2);

                    Console.WriteLine(number);

                    if (number == 0)
                    {
                        tailCount++;
                    }else
                    {
                        headCount++;
                    }
                }

                Console.WriteLine("The TailCount is " + tailCount);
                Console.WriteLine("The headCount is " + headCount);

                headpercentage = (headCount * 100) / flip;
                tailpercentage = (tailCount * 100) / flip;

                Console.WriteLine("The tailPercentage is " + tailpercentage);
                Console.WriteLine("The headPercentage is " + headpercentage);

            }
            else
            {
                Console.WriteLine("Please enter the correct number");
            }
        }

    }
}
