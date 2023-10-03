using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_2
{
    class student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public int Semester { get; set; }
        public string Branch { get; set; }
        public int[] Marks { get; } = new int[5];

        public student(int rollNo, string name, string className, int semester, string branch)
        {
            RollNo = rollNo;
            Name = name;
            Class = className;
            Semester = semester;
            Branch = branch;
        }

        public void GetMarks()
        {
            Console.WriteLine($"Roll Number: {RollNo}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Class: {Class}");
            Console.WriteLine($"Semester: {Semester}");
            Console.WriteLine($"Branch: {Branch}");
            Console.WriteLine("Marks in Subjects:");

            for (int i = 0; i < Marks.Length; i++)
            {
                Console.WriteLine($"Subject {i + 1}: {Marks[i]}");
            }
        }
        public void DisplayResult()
        {
            double totalMarks = 0;
            foreach (int mark in Marks)
            {
                totalMarks += mark;
            }
            double averageMarks = totalMarks / Marks.Length;
            if (Marks.Any(mark => mark < 35))
            {
                Console.WriteLine("Result: Failed");
            }
            else if (averageMarks < 50)
            {
                Console.WriteLine("Result: Failed)");
            }
            else
            {
                Console.WriteLine("Result: Passed");
            }
        }

        class Program
        {
            static void Main()
            {

                student student = new student(015, "Sahithi", "Btech", 2, "ECE");
                Console.WriteLine("Enter marks for 5 subjects:");
                for (int i = 0; i < student.Marks.Length; i++)
                {
                    Console.Write($"Subject {i + 1}: ");
                    student.Marks[i] = int.Parse(Console.ReadLine());
                }
                student.GetMarks();
                student.DisplayResult();
                Console.ReadKey();
            }
        }
    }
}

