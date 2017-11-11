using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ma valin numbri vahemikus [1-100]. Proovi see ära arvata.");
            Console.WriteLine();



            Random random = new Random();
            int magicNumber = random.Next(1, 100);
            bool arvamine = true;


            while (arvamine)
            {
                Console.Write("Sinu number: ");
                string input = Console.ReadLine();
                int number = int.Parse(input);





                if (magicNumber > number)
                {
                    Console.WriteLine("Sinu number on väiksem.");
                }

                if (magicNumber < number)
                {
                    Console.WriteLine("Sinu number on suurem.");
                }

                if (magicNumber == number)
                {
                    break;
                }




            }


            Console.WriteLine("Arvasid ära.");

            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
        }
    }
}
