using System;

namespace _04Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1,2,3,4,5,6,7,8,9,1,2,4,8,6,1,5,1,3,1,5,1,2,5 };
            RepeatNumbersInArray(array);
        }
        static void RepeatNumbersInArray(params int[] num)
        {
            int j = 0;
            Console.Write($"write a number :");
            int a = int.Parse(Console.ReadLine());
            for (int i = 0 ; i < num.Length; i++)
            {
                if (a ==num[i])
                {
                    j++;
                }
            }
            Console.WriteLine(j);
        }
    }
}
