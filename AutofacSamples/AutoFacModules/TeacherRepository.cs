using System;

namespace AutoFacModules
{
    public class TeacherRepository : ITeacherRepository
    {

        public void Print(Teacher teacher)
        {
            Console.WriteLine("Printing Teacher");
            Console.WriteLine(string.Format("Teaher id: {0}", teacher.TeacherId));
            Console.WriteLine(string.Format("First Name: {0}", teacher.FirstName));
            Console.WriteLine(string.Format("Last Name: {0}", teacher.LastName));
            Console.WriteLine(string.Format("Subject: {0}", teacher.Subject));
            Console.Read();
        }
    }
}
