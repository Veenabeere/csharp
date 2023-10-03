using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codebasetest3
{
    class Box1
    {
        public double Length { get; set; }
        public double Breadth { get; set; }

        public Box1(double l, double b)
        {
            Length = l;
            Breadth = b;
        }

        public static Box1 Add(Box1 box1, Box1 box2)
        {
            double sumL = box1.Length + box2.Length;
            double sumB = box1.Breadth + box2.Breadth;
            return new Box1(sumL, sumB);
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Length: {Length}, Breadth: {Breadth}");
        }
    }

    class BoxTest
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of Box 1: ");
            double l1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the breadth of Box 1: ");
            double b1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the length of Box 2: ");
            double l2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the breadth of Box 2: ");
            double b2 = Convert.ToDouble(Console.ReadLine());

            Box1 box1 = new Box1(l1, b1);
            Box1 box2 = new Box1(l2, b2);

            Box1 box3 = Box1.Add(box1, box2);

            Console.WriteLine("Box1 details are:");
            box1.DisplayDetails();
            Console.ReadLine();

            Console.WriteLine("Box2 details are:");
            box2.DisplayDetails();
            Console.ReadLine();

            Console.WriteLine("Box3 details are the sum of box 1 and box2:");
            box3.DisplayDetails();
            Console.ReadLine();
        }
    }
}
