using System;

namespace _10Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Enter a number of fackturial : ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(FactorialIteration(a));
            Console.Write($"Enter a number of fackturial : ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(FactorialRecursion(b));
            
            
                
        }
        static int FactorialIteration(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
              fact *= i;

                
            }
            return fact;
        }
        static int FactorialRecursion(int n)
        {
            if(n == 0)
            {
                return 1;
            }
            return FactorialRecursion(n - 1) * n;
        }

    }
}
