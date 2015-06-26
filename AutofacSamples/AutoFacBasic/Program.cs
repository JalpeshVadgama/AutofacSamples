using Autofac;
using System;

namespace AutoFacBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            //registering interface with class that implemented
            var builder = new ContainerBuilder();
            builder.RegisterType<PrintService>().As<IPrintService>();

            //Resolving inteface with autofac
            var container = builder.Build();
            var printService = container.Resolve<IPrintService>();
            printService.PrintSomething("Hello World");
            Console.ReadKey();
        }

    }

}
