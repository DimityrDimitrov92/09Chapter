using System;

namespace _01Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeting("Dimityr");
        }
        static void Greeting(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
    }
}
