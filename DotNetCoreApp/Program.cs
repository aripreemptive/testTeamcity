using System;

namespace DotNetCoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DotNetCoreDll.Class1 dc = new DotNetCoreDll.Class1();
            dc.DoStuff();

        }
    }
}
