
using System;
using System.Collections.Generic;
namespace CaseStudy1
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Student(int id, string name, DateTime dateOfBirth)
        {
            Id = id;
            Name = name;
            DateOfBirth = (dateOfBirth);
        }
    }

    class Course

    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
   public Course(int courseId, string courseName)

        {

            CourseId = courseId;
            CourseName = courseName;
        }

    }
 class Enroll

    {
        public Student Student { get; set; }
        public Course Course { get; set; }
        public DateTime EnrollmentDate { get; set; }
      public Enroll(Student student, Course course, DateTime enrollmentDate)

        {

            Student = student;
           Course = course;
            EnrollmentDate = enrollmentDate;

        }

    }



    class AppEngine

    {

        private List<Student> students = new List<Student>();
        private List<Course> courses = new List<Course>();
        private List<Enroll> enrollments = new List<Enroll>();
    public void Introduce(Course course)

        {
            courses.Add(course);
        }
        public void Register(Student student)
        {
            students.Add(student);
        }
        public Student[] ListOfStudents()
        {
            return students.ToArray();
        }
        public List<Student> ListofStudents()
        {
            return students;
        }
     public List<Course> ListofCourses()
        {
            return courses;
        }
        public Course[] ListOfCourses()
        {
            return courses.ToArray();
        }
   public void Enroll(Student student, Course course)
        {
            enrollments.Add(new Enroll(student, course, DateTime.Now));
        }
   public Enroll[] ListOfEnrollments()
        {
            return enrollments.ToArray();
        }
        public List<Enroll> ListofEnrollments()
        {
            return enrollments;
        }
    }
    class Info
    {
        public void displayStudent(Student student)
        { 
            Console.WriteLine($"studentid: {student.Id} \t name: {student.Name} \t dateofbirth: {student.DateOfBirth.ToShortDateString()}");
        }
        public static void DisplayEnrollments(Enroll[] enrollments)
        {
            foreach (var enrollment in enrollments)

            {
                Console.WriteLine($"Student: {enrollment.Student.Name}, Course: {enrollment.Course.CourseName}, Enrollment Date: {enrollment.EnrollmentDate}");
            }

        }

    }
    class App

    {
        public static void scenario1()
        {
            Console.WriteLine("\nCASESTUDY 1 OUTPUT\n");
            Student obj1 = new Student(70, "veena", new DateTime(2000, 9, 26));
            Student obj2 = new Student(72, "hema", new DateTime(2004, 12, 26));
            Student obj3 = new Student(58, "sahithi", new DateTime(2005, 07, 18));
            Info info = new Info();
            info.displayStudent(obj1);
            info.displayStudent(obj2);
            info.displayStudent(obj3);
            Console.WriteLine("\n");
        }
        public static void scenario2()
        {
            Student[] array = new Student[3];
            array[0] = new Student(72, "chandu", new DateTime(2000, 06, 15));
            array[1] = new Student(4, "sindu", new DateTime(2005, 5, 5));
            array[2] = new Student(95, "kittu", new DateTime(2000, 08, 2));
         Info info = new Info();

            foreach (Student student in array)
            {
                info.displayStudent(student);
            }
        }
        interface UserInterface

        {
            void ShowFirstScreen();
            void ShowStudentScreen();
            void ShowAdminScreen();
            void ShowAllStudentsScreen();
            void ShowStudentRegistrationScreen();
            void IntroduceNewCourseScreen();
            void ShowAllCoursesScreen();
        }
        class ConsoleUserInterface : UserInterface
        {
            public AppEngine appEngine = new AppEngine();
      public void ShowFirstScreen()
            {
                Console.WriteLine("Welcome to SMS (Student Management System) v1.0");
                Console.WriteLine("Tell us who you are:\n1. Student\n2. Admin");
                Console.WriteLine("Enter your choice (1 or 2): ");
                int op = Convert.ToInt32(Console.ReadLine());
             switch (op)
                {
                    case 1:
                        ShowStudentScreen();
                        break;
                    case 2:
                        ShowAdminScreen();
                        break;
                }
            }
            public void ShowStudentScreen()
            {
                Console.WriteLine("Student Menu:");
                Console.WriteLine("1. View All Courses");
                Console.WriteLine("2. Register for a Course");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                       ShowAllCoursesScreen();
                        break;
                    case 2:
                        ShowStudentRegistrationScreen();
                        break;
                }
            }
        public void ShowAdminScreen()
            {
                Console.WriteLine("Admin Menu:");
                Console.WriteLine("1. Introduce New Course");
                Console.WriteLine("2. View All Students");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        IntroduceNewCourseScreen();
                        break;
                    case 2:
                        ShowAllStudentsScreen();
                        break;
                }
                
            }
          public void ShowAllStudentsScreen()
            {
                appEngine.Register(new Student(1, "maneesh", new DateTime(2018, 10, 15)));
                appEngine.Register(new Student(2, "ganga", new DateTime(2002, 12, 2)));
                List<Student> students = appEngine.ListofStudents();
                students = appEngine.ListofStudents();
                Console.WriteLine("All Students:");
                foreach (var student in students)
                {
                    Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, dateofbirth: {student.DateOfBirth.ToShortDateString()}");
                }
            }
            public void ShowStudentRegistrationScreen()
            {
                ShowAllStudentsScreen();
                Console.WriteLine("Enter the ID of the student you want to register:");
                int studentId = Convert.ToInt32(Console.ReadLine());
                ShowAllCoursesScreen();
                Console.WriteLine("Enter the Course ID you want to register for:");
                int courseId = Convert.ToInt32(Console.ReadLine());
               var student = appEngine.ListofStudents().Find(s => s.Id == studentId);
                var course = appEngine.ListofCourses().Find(c => c.CourseId == courseId);
                if (student != null && course != null)
                {
                    appEngine.Enroll(student, course);
                    Console.WriteLine("Enrolled successfully!");
                }
               else
                {
                    Console.WriteLine("Invalid student or course ID. Enrollment failed.");
                }
            }
            public void IntroduceNewCourseScreen()
            {
                Console.WriteLine("Enter the name of the new course:");
                string courseName = Console.ReadLine();
                int newCourseId = appEngine.ListofCourses().Count + 1;
                Course newCourse = new Course(newCourseId, courseName);
                appEngine.Introduce(newCourse);
                Console.WriteLine($"New course '{courseName}' introduced with Course ID: {newCourseId}");
            }
            public void ShowAllCoursesScreen()
            {
                appEngine.Introduce(new Course(1, "Maths"));
                appEngine.Introduce(new Course(2, "Physics"));
                List<Course> courses = appEngine.ListofCourses();
                courses = appEngine.ListofCourses();
                Console.WriteLine("All Courses:");
                foreach (var course in courses)
                {
                   Console.WriteLine($"Course ID: {course.CourseId}, Name: {course.CourseName}");
                }
            }
            public static void Main(string[] args)
            {
                App.scenario1();
                App.scenario2();
                AppEngine appEngine = new AppEngine();
                Course course1 = new Course(1, "Maths");
                Course course2 = new Course(2, "Science");
                appEngine.Introduce(course1);
                appEngine.Introduce(course2);
               Console.WriteLine("\n-------------------------------------------\n");
                Console.WriteLine("\nCaseStudy 2 \n");
                Student student1 = new Student(70, "veenu", new DateTime(2002, 08, 25));
                Student student2 = new Student(72, "lalli", new DateTime(2000, 2, 23));
                appEngine.Register(student1);
                appEngine.Register(student2);
                appEngine.Enroll(student1, course1);
                appEngine.Enroll(student2, course2);
                Enroll[] enrollments = appEngine.ListOfEnrollments();
               Console.WriteLine("Enrollments:");
                Info.DisplayEnrollments(enrollments);
                Console.WriteLine("\n-------------------------------------------\n");
                Console.WriteLine("\nCaseStudy 3 n 4\n");
                UserInterface userInterface = new ConsoleUserInterface();
                userInterface.ShowFirstScreen();
                Console.ReadLine();

            }

        }





    }

}