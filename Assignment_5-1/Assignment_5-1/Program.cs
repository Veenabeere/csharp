using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_1
{
    /*1. Create a Class Program which would be used to accepts two Strings - FirstName and LastName and call 
     the static method Display() that displays the first name in one line and the LastName in the second line
     after converting the same to upper case.
    */
    class Program
    {

        public static void Display(string FirstName, string LastName)
        {
            FirstName = FirstName.ToUpper();
            LastName = LastName.ToUpper();


            Console.WriteLine(FirstName);
            Console.WriteLine(LastName);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter your First Name: ");
            string FirstName = Console.ReadLine();

            Console.Write("Enter your Last Name: ");
            string LastName = Console.ReadLine();


            Display(FirstName, LastName);
            Console.ReadLine();
        }
    }
}