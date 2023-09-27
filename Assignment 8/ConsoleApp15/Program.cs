using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("enter shape name :");
            string ShapeType = Console.ReadLine();
           
            IShape cc = CreditCardFactory.ShapeType(ShapeType);


            if (cc != null)
            {
                Console.WriteLine("Shape Type : {0}", cc.ShapeType());
                Console.WriteLine("Area : {0}", cc.GetArea());
                Console.WriteLine("Circumference : {0}", cc.GetCircumference());
            }
            else
            {
                Console.WriteLine("Invalid shapetype.. please give correct type");
            }
            Console.Read();
        }
    }
}