using Autofac;
using System;
namespace AutoFacBasic
{
    class Program
    {
        static void Main(string[] args)
        {

            var builder = new ContainerBuilder();
            builder.RegisterType<PrintService>().As<IPrintService>();

            var container = builder.Build();
            var printService = container.Resolve<IPrintService>();
            printService.PrintSomething("Hello World");
            Console.ReadKey();
        }

    }

}
