using System;

namespace ConTest
{
    class Program
    {
      

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine($@"{new User() { Name="张三",Sex="女" }}");

            Console.ReadLine();
        }
    }
}
