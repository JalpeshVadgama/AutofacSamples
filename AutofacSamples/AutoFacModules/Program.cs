using Autofac;

namespace AutoFacModules
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a Student object
            Student student = new Student
            {
                StudentId = 1,
                FirstName = "Vishal",
                LastName = "Vadgama",
                Department = "Information Technology"
            };

            //Creating a teacher object
            Teacher teacher = new Teacher
            {
                TeacherId = 1,
                FirstName = "Jalpesh",
                LastName = "Vadgama",
                Subject = "Computer Applciations"
            };

            //getting container object
            var container = BuildContainer();

            //Resolving student repository
            var studentRepository = container.Resolve<IStudentRepository>();
            //Printing student
            studentRepository.Print(student);

            //Resolving teacher repository
            var teacherRepository = container.Resolve<ITeacherRepository>();
            //Printing Teacher
            teacherRepository.Print(teacher);

        }

        static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();

            //Registering Modules
            builder.RegisterModule<StudentModule>();
            builder.RegisterModule<TeacherModule>();

            return builder.Build();
        }

    }


}
