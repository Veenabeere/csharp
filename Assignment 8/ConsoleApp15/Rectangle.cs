using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Rectangle : IShape
    {

        public double len = 5;
        public double wid = 3;
        public double GetCircumference()
        {
            return 2 * (len + wid);
        }

        public double GetArea()
        {
            return len * wid;
        }

        public string ShapeType()
        {
            return "Rectangle";
        }
    }
}