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
            int number;
            bool canExitApp = true;
            bool isResultReadInt = true;

            Console.Write("Введите число: ");
            numberInput = Console.ReadLine();

            isResultReadInt = int.TryParse(numberInput, out number);

            while (canExitApp)
            {
                if (isResultReadInt)
                {
                    Console.Write($"Число - {number}, успешно сконвертировано!");
                    canExitApp = false;
                }
                else
                {
                    Console.WriteLine($"Не удалось сконвертировать {number}, попробуйте ещё раз.");
                    Console.Write("Введите число: ");
                    numberInput = Console.ReadLine();
                    isResultReadInt = int.TryParse(numberInput, out number);
                }
            }

            return number;
        }
    }
}
