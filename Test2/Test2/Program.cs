using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    /*Create an Abstract class Student with  Name, StudentId, Grade as members 
     * and also an abstract method Boolean Ispassed(grade) which takes
     * grade as an input and checks whether student passed the course or not.2 Sub classes Undergraduate 
     * and Graduate that inherits all members of the student and overrides Ispassed(grade) method For
     * the UnderGrad class, if the grade is above 70.0, then isPassed returns true, otherwise it returns false.
     * For the Grad class, if the grade is above 80.0, then isPassed returns true, otherwise returns false.
       Test the above by creating appropriate objects*/

    abstract class Student
    {
      public  string name;
      public  int StudentId;
       public double Grade;
        public abstract Boolean Ispassed(double Grade);
        public void Undergrad(string name, int StudentId, double Grade)
        {
            this.name = name;
            this.StudentId = StudentId;
            this.Grade = Grade;
        }

    }

    class Udergrad : Student
    {
       
        public override Boolean Ispassed(double grade)
        {
            return grade > 70.0;
        }
    }
    class Graduate : Student
    {
        public override Boolean Ispassed(double grade)
        {
            return grade > 80.0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var udergrade = new Udergrad();
            udergrade.name = "veena";
            udergrade.StudentId = 015;
            udergrade.Grade = 90.1;

            var grade = new Graduate();
            grade.name = "jaanu";
            grade.StudentId = 125;
            grade.Grade = 89.0;
            Console.WriteLine($"{udergrade.name},{ udergrade.StudentId} passed: {udergrade.Ispassed(udergrade.Grade)}");
            Console.WriteLine($"{grade.name},{grade.StudentId} passed: {grade.Ispassed(grade.Grade)}");

            Console.ReadLine();

        }
    }
}
