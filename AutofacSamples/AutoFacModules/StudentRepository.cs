using System;
namespace AutoFacModules
{
    public class StudentRepository : IStudentRepository
    {

        public void Print(Student student)
        {
            Console.WriteLine("Printing Student");
            Console.WriteLine(string.Format("Student Id : {0}", student.StudentId));
            Console.WriteLine(string.Format("First name: {0} ", student.FirstName));
            Console.WriteLine(string.Format("Last Name : {0} ", student.LastName));
            Console.WriteLine(string.Format("Department : {0} ", student.Department));
        }
    }
}
