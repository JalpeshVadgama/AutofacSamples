using System;

namespace AutoFacBasic
{
    public class PrintService : IPrintService
    {
        public void PrintSomething(string text)
        {
            Console.WriteLine(text);
        }
    }
}
