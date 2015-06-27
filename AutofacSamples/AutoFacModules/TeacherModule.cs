using Autofac;

namespace AutoFacModules
{
    public class TeacherModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<TeacherRepository>().As<ITeacherRepository>();
            base.Load(builder);
        }
    }
}
