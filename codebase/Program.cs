using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codebase
{
    class Program
    {
        static void Main(string[] args)
        {
                string[] inputs = { "Python", "Python", "Python" };
                int[] positions = { 1, 0, 4 };

                for (int i = 0; i < inputs.Length; i++)
                {
                    string input = inputs[i];
                    int position = positions[i];
                    if (position >= 0 && position < input.Length)
                    {
                        string result = input.Remove(position, 1);
                        Console.WriteLine(result);
                         Console.ReadLine();
                }
                    else
                    {
                        Console.WriteLine("Invalid position.");
                        Console.ReadLine();
                    }
                }
            }
        }
    }
    
