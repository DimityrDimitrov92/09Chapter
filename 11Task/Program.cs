using System;

namespace _11Task
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"                                   ##      ##  #########  ##         ##  ##       ##");
            Console.WriteLine($"                                   ####  ####  ##         ## ##      ##  ##       ##");
            Console.WriteLine($"                                   ## #### ##  ##         ##  ##     ##  ##       ##");
            Console.WriteLine($"                                   ##  ##  ##  #########  ##    ##   ##  ##       ##");
            Console.WriteLine($"                                   ##      ##  ##         ##      ## ##  ##       ##");
            Console.WriteLine($"                                   ##      ##  ##         ##        # #   ##     ##");
            Console.WriteLine($"                                   ##      ##  #########  ##         ##     ## ##");
            Console.SetCursorPosition(40, 10);
            Console.WriteLine($"1.Reverse digit of the number. ");
            Console.SetCursorPosition(40, 12);
            Console.WriteLine($"2.Calculate the arithmetic of a numbers");
            Console.SetCursorPosition(40, 14);
            Console.WriteLine($"3.Calculate a linear equation");
            int a = 16;

            int menuChoose = 0;
            do
            {
                Console.SetCursorPosition(65, a);
                Console.WriteLine($"                     <<<<<<<<<<------------");
                
                Console.SetCursorPosition(5,a);
                
                Console.Write($"------------>>>>>>>>>>               Enter number between 1-3 : ");
                menuChoose = int.Parse(Console.ReadLine());
                a++;
            } while (menuChoose<1 ||menuChoose>3);
            switch (menuChoose)
            {
                case 1:
                    Reverse();
                    break;
                case 2:
                    CalculatingMiddleValue();
                    break;
                case 3:
                    CalculateAbC();
                    break;
            }





        }
        static void Reverse()
        {
            Console.Clear();
            string textToEnter = "Enter number between 10 - 50 000 000";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));
            Console.WriteLine();
            string ab = "Result is =";
            long num;
            do
            {
                Console.Write($"Enter int number : ");
                num = long.Parse(Console.ReadLine());
 
            } while (num < 10 || num >= 50000000);

            string number = Convert.ToString(num);
            char[] charArray = number.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(charArray);


        }
        static void CalculatingMiddleValue()
        {
            Console.Clear();
            double result = 0;
              int lenght = 0;
            string textToEnter = "Calculate the arithmetic of a numbers!";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));
            

            do
            {
                Console.Write($"Enter lenght of array : ");
                lenght = int.Parse(Console.ReadLine());
            } while (lenght == 0);
            double[] numbers = new double[lenght];



            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter {i+1} number : ");
                numbers[i] = int.Parse(Console.ReadLine());
                result += numbers[i] / 2;
            }
            Console.WriteLine($"The result middle arithmetic of a numbers = {result}");
        }
        static void CalculateAbC()
        {
            Console.Clear();
            int a;
            string textToEnter = "Calculate a linear equation";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));
            do
            {
                Console.Write($"Enter a (!=0) : ");
                a = int.Parse(Console.ReadLine());
            } while (a == 0);
            Console.Write($"Enter b : ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("x = {0}", (float)-b / a);
            Console.ReadLine();

        }
    }
}
