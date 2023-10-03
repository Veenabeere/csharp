using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codebase2
{
    class Program
    {
        static void Main(string[] args)
        {
            int j, n;

            Console.WriteLine("\n\n");
            Console.WriteLine("Display the multiplication table:\n");
            

            Console.Write("Input the number: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            for (j = 1; j <= 10; j++)
            {
                Console.WriteLine("{0} X {1} = {2} \n", n, j, n * j);
                Console.ReadLine();

            }
        }
    }
}

