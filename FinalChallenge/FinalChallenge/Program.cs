using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace FinalChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
           using(var db = new StudentContext())
            {
                Console.WriteLine("Enter First Name: ");
                var firstName = Console.ReadLine();
                Console.WriteLine("Enter Last Name:");
                var lastName = Console.ReadLine();

                var student = new Student() { FirstName = firstName, LastName = lastName };

                db.Students.Add(student);
                db.SaveChanges();

                Console.WriteLine("\n\nStudents in Database:\n");
                foreach(var stud in db.Students)
                {
                    Console.WriteLine(stud.FirstName + " " + stud.LastName);
                }
            }
        }
    }

    // Student Class
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Grade Grade { get; set; }
    }

    // Grade Class

    public class Grade
    {
        public int GradeId { get; set; }
        public string Course { get; set; }

        public ICollection<Student> Students { get; set; }
    }

    // StudentContext Class
    public class StudentContext : DbContext
    {
        public StudentContext() : base()
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }

}