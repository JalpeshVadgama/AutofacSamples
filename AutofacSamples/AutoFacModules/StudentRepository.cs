
using System;
namespace AutoFacModules
{
    public class StudentRepository : IStudentRepository
    {

        public void Print(Student student)
        {
            Console.Write("Printing Student");
            Console.Write(string.Format("Student Id : {0) ", student.StudentId));
            Console.Write(string.Format("First name: {0) ", student.FirstName));
            Console.Write(string.Format("Last Name : {0) ", student.LastName));
            Console.Write(string.Format("Department : {0) ", student.Department));
        }
    }
}
