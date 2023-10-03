using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace codeasetest4
{
    // Write a program in C# Sharp to append some text to an existing file.
    // If file is not available, then create one.
    class first
    {
       private static void Main(string[] arg)
        {
            string Path = "D:\\csharp\\Codebasetests_C#\\codeasetest4.txt";
        
                string Append = "This text will be appended to the file.";


                if (!File.Exists(Path))
                {
                    using (StreamWriter writer = File.CreateText(Path))
                    {
                        writer.WriteLine(Append);
                    }
                    Console.WriteLine("File created and text has been added.");
                }
                else
                {

                    using (StreamWriter writer = new StreamWriter(Path, true))
                    {
                        writer.WriteLine(Append);
                    }
                    Console.WriteLine("Text has been appended to the file.");
                }
                Console.ReadLine();
            }
        }
    }
    

