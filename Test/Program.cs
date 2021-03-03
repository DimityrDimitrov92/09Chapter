using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;

            do
            {
                Console.Clear();
                Console.Write("Vuvedete a: ");
                a = int.Parse(Console.ReadLine());
            } while (a == 0);

            Console.Write("Vuvedete b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("x = {0}", (float)-b / a);
            Console.ReadLine();

        }
    }
}
