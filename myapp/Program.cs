using System;
using System.Threading.Tasks;

namespace myapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Func1();
            Func2();
        }

        private static void Func1()
        {
            Task.Delay(5000).Wait();
        }

        private static void Func2() =>
            Task.Delay(1000).Wait();

    }
}
