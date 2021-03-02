using System;

namespace _02Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int a =GetMax(5,25,1);
            Console.WriteLine(a);
        }
        static int GetMax(int a ,int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
            
        }
    }
}
