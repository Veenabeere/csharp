using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concessionmain
{
    class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Name of Passenger");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter the Age of Passenger:");
            int age = Convert.ToInt32(Console.ReadLine());

            Concession.concession cc = new Concession.concession();
            cc.CalculateConcession(Name, age);
        }

    }
}