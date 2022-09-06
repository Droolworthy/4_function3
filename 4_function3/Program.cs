using System;

namespace _4_function3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadInt();
        }

        static int ReadInt()
        {
            string numberInput;
            int number = 0;
            bool canExitMethod = true;

            while (canExitMethod)
            {
                Console.Write("Введите число: ");
                numberInput = Console.ReadLine();

                bool isResultReadInt = int.TryParse(numberInput, out number);

                if (isResultReadInt)
                {
                    Console.Write($"Число - {number}, успешно сконвертировано!");
                    canExitMethod = false;
                }
                else
                {
                    Console.WriteLine($"Не удалось сконвертировать {number}, попробуйте ещё раз.");
                }
            }
            
            return number;
        }
    }
}
