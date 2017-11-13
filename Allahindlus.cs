using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Allahindluse kalkulaator.");
            Console.WriteLine("Sisestage kauba maksumus: ");

            string input = Console.ReadLine();
            int number = int.Parse(input);

            
            if (number >= 50 && number < 250) {
                Console.WriteLine("Hind tavakliendile on: " + number * 0.9);
                Console.WriteLine("Hind püsikliendile on: " + number * 0.8);
                              
            }

            if (number >= 250 && number < 350)
            {
                Console.WriteLine("Hind tavakliendile on: " + number * 0.8);
                Console.WriteLine("Hind püsikliendile on: " + number * 0.7);


            }

            if (number > 350)
            {
                Console.WriteLine("Hind tavakliendile on: " + number * 0.7);
                Console.WriteLine("Hind püsikliendile on: " + number * 0.6);
            }

            if (number < 50)
            {
                Console.WriteLine("Hind tavakliendile on: " + number);
                Console.WriteLine("Hind püsikliendile on: " + number);
            }


            Console.ReadKey();
            

        }
    }
}
