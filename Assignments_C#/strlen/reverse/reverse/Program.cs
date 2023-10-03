using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "veena";
            string reverse = "";
            for (int i = 4; i >= 0; i--)
            {
                reverse += str[i];
            }
            Console.WriteLine(reverse);
            Console.ReadLine();
        }
    }
}
