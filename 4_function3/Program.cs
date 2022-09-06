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
            bool canExitMethod = true;

            Console.Write("Введите число: ");
            numberInput = Console.ReadLine();

            bool isResultReadInt = int.TryParse(numberInput, out number);

            while (canExitMethod)
            {
                if (isResultReadInt)
                {
                    Console.Write($"Число - {number}, успешно сконвертировано!");
                    return number;
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
