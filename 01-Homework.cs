using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ma valin numbri vahemikus [1-100]. Proovi see ära arvata.");
            Console.WriteLine();

            Console.Write("Sinu number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            int magicNumber = 63;

            if (magicNumber > number)
            { Console.WriteLine("Sinu number on väiksem.");
            }

            if (magicNumber < number)
            { Console.WriteLine("Sinu number on suurem.");
            }

            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();

        }
    }
}
