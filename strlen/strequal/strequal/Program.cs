using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strequal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter my name");
            string Myname = Console.ReadLine();
            Console.WriteLine("enter my age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"myname{Myname},age{age}");

            Console.ReadLine();
        }
    }
}
