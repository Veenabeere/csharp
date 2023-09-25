using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codebasetest3
{

    //Write a program to find the Sum and the Average points scored
    //by the teams in the IPL. Create a Class called Cricket that has a function called Points
    //calculation(int no_of_matches) that takes no.of matches as input and accepts that many scores from the user.
    //The function should then display the Average and Sum of the scores.


    class Cricket
    {
        public string PointsCalculation(int no_of_matches)
        {
            int i;
            int sum = 0;
            double avg;
            for (i = 1; i <= no_of_matches; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                sum = sum + n;
            }
            avg = sum / 10.0;
            Console.WriteLine("Sum =" + sum);
            Console.WriteLine("Average =" + avg);
            Console.ReadLine();

            return "done";

        }
        static void Main(string[] args)
        {
            Cricket n = new Cricket();
            Console.WriteLine("Enter the number of matches:");
            int no_of_matches = Convert.ToInt32(Console.ReadLine());
            n.PointsCalculation(no_of_matches);
            Console.ReadLine();
        }
    }
}

