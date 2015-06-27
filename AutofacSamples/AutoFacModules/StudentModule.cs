using Autofac;

namespace AutoFacModules
{
    public class StudentModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<StudentRepository>().As<IStudentRepository>();
            base.Load(builder);
        }
    }
}
