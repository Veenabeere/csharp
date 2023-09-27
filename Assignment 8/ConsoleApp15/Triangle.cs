using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Triangle : IShape
    {
        public int a = 5 ,h=2;
        public int b = 7, c = 4;
        public double GetCircumference()
        {
            return a+b+c;
        }

        public double GetArea()
        {
            return 0.5*a*h;
        }

        public string ShapeType()
        {
            return "Triangle";
        }
    }
}