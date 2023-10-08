using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASESTUDY
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }

        public Student(int id, string name, DateTime DOB)
        {
            Id = id;
            Name = name;
            DOB = (DOB);
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

    class AppE
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
            Console.WriteLine($"studentid: {student.Id} name: {student.Name} DOB: {student.DOB.ToShortDateString()}");

        }
        public void Displaycourse(Course course)
        {
            Console.WriteLine($"CourseId: {course.CourseId}  CourseName:{course.CourseName}");



        }
        public static void DisplayEnrollments(Enroll[] enrollments)
        {
           
            foreach (var enrollment in enrollments)
            {
                Console.WriteLine($"Student: {enrollment.Student.Name}, Course: {enrollment.Course.CourseName}, Enrollment Date: {enrollment.EnrollmentDate}");
            }
        }


        public interface IUserInterface
        {
            void ShowFirstScreen();
            void ShowStudentScreen();
            void ShowAdminScreen();
            void ShowAllStudentsScreen();
            void ShowStudentRegistrationScreen();
            void IntroduceNewCourseScreen();
            void ShowAllCoursesScreen();
        }


        public class UserInterface : IUserInterface
        {
            private AppE AppE = new AppE();

            public void ShowFirstScreen()
            {
                Console.WriteLine("Welcome to SMS (Student Mgmt. System) v1.0");
                Console.WriteLine("Tell us who you are : \n1. Student\n2. Admin\n3. Exit");
                Console.Write("Enter your choice (1, 2, or 3): ");
                int opt = Convert.ToInt32(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        ShowStudentScreen();
                        break;
                    case 2:
                        ShowAdminScreen();
                        break;
                    case 3:
                        Console.WriteLine("Exiting the program. Goodbye!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                        ShowFirstScreen();
                        break;
                }
            }

            public void ShowStudentScreen()
            {
                Console.WriteLine("Student Menu:");
                Console.WriteLine("1. View All Courses");
                Console.WriteLine("2. Register for a Course");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice (1-3): ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ShowAllCoursesScreen();
                        break;
                    case 2:
                        ShowStudentRegistrationScreen();
                        break;
                    case 3:
                        Console.WriteLine("Exiting Student Menu.");
                        ShowFirstScreen();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option (1-3).");
                        ShowStudentScreen();
                        break;
                }
            }

            public void ShowAdminScreen()
            {
                Console.WriteLine("Admin Menu:");
                Console.WriteLine("1. Introduce New Course");
                Console.WriteLine("2. View All Students");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice (1-3): ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        IntroduceNewCourseScreen();
                        break;
                    case 2:
                        ShowAllStudentsScreen();
                        break;
                    case 3:
                        Console.WriteLine("Exiting Admin Menu.");
                        ShowFirstScreen();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option (1-3).");
                        ShowAdminScreen();
                        break;
                }
            }

            public void ShowAllStudentsScreen()
            {
                Console.WriteLine("List of Students:");
                App.scenario1();
                App.scenario2();
                
                Console.WriteLine("Press Enter to return to the previous menu...");
                Console.ReadLine();
                ShowAdminScreen();
            }

            public void ShowStudentRegistrationScreen()
            {
                Console.Write("Enter Student ID: ");
                int studentId = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Student Name: ");
                string studentName = Console.ReadLine();
                Console.Write("Enter Student Date of Birth (yyyy-MM-dd): ");
                DateTime studentDob = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Enter cousre Id: ");
                int courseId = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter course name: ");
                string courseName = Console.ReadLine();


              
                AppE.Register(new Student(studentId, studentName, studentDob));
                AppE.Introduce(new Course(courseId, courseName));
                Console.WriteLine("Student registered successfully.");
                Console.WriteLine("Press Enter to return to the previous menu...");
                Console.ReadLine();
                ShowStudentScreen();
            }

            public void IntroduceNewCourseScreen()
            {
                Console.Write("Enter Course ID: ");
                int courseId = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Course Name: ");
                string courseName = Console.ReadLine();

               
                AppE.Introduce(new Course(courseId, courseName));
                Console.WriteLine("Course introduced successfully.");
                Console.WriteLine("Press Enter to return to the previous menu...");
                Console.ReadLine();
                ShowAdminScreen();
            }

            public void ShowAllCoursesScreen()
            {
                Console.WriteLine("List of Courses:");
                App.courses();
               
                Console.WriteLine("Press Enter to return to the previous menu...");
                Console.ReadLine();
                ShowStudentScreen();
            }
        }

        public class App
        {
            public static void scenario1()
            {

                Student obj1 = new Student(70, "deepu", new DateTime(2002, 08, 25));
                Student obj2 = new Student(72, "likki", new DateTime(2001, 12, 26));
                Student obj3 = new Student(58, "vinni", new DateTime(2001, 04, 19));
                Info info = new Info();
                info.displayStudent(obj1);
                info.displayStudent(obj2);
                info.displayStudent(obj3);
            }
            public static void scenario2()
            {
                Student[] array = new Student[3];
                array[0] = new Student(59, "chandana", new DateTime(2000, 06, 29));
                array[1] = new Student(64, "srivalli", new DateTime(2000, 04, 14));
                array[2] = new Student(65, "keerthisri", new DateTime(2000, 09, 23));

                Info info = new Info();

                foreach (Student student in array)
                {
                    info.displayStudent(student);


                }
            }
            public static void courses()
            {
                Course course1 = new Course(1, "C#");
                Course course2 = new Course(2, "C");
                Course course3 = new Course(3, "C++");
                Course course4 = new Course(4, "Python");
                Course course5 = new Course(5, "Sql");
                Course course6 = new Course(6, "Java");
                Info info = new Info();
                info.Displaycourse(course1);
                info.Displaycourse(course2);
                info.Displaycourse(course3);
                info.Displaycourse(course4);
                info.Displaycourse(course5);
                info.Displaycourse(course6);



            }
            static void Main(string[] args)
            {

                AppE AppE = new AppE();

                Course course1 = new Course(1, "C#");
                Course course2 = new Course(2, "C");
                AppE.Introduce(course1);
                AppE.Introduce(course2);

                Student student1 = new Student(70, "deepu", new DateTime(2002, 08, 25));
                Student student2 = new Student(72, "likki", new DateTime(2001, 12, 26));
                AppE.Register(student1);
                AppE.Register(student2);

                AppE.Enroll(student1, course1);
                AppE.Enroll(student2, course2);

                Enroll[] enrollments = AppE.ListOfEnrollments();

                Console.WriteLine("Enrollments:");
                Info.DisplayEnrollments(enrollments);
                Console.WriteLine("\n**********\n");

                new UserInterface().ShowFirstScreen();

            }
        }
    }
    }
