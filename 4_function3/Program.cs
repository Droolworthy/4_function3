using System;

namespace _4_function3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numberInput;
            int number;
            bool canExitApp = true;
            bool isResultReadInt;

            Console.Write("Введите номер: ");
            numberInput = Console.ReadLine();

            isResultReadInt = int.TryParse(numberInput, out number);

            ReadInt(number, isResultReadInt, canExitApp);
        }

        static int ReadInt(int number, bool result, bool canExitApp)
        {
            string numberInput;

            while (canExitApp)
            {
                if (result)
                {
                    Console.Write($"Число - {number}, успешно сконвертировано!");
                    canExitApp = false;
                }
                else
                {
                    Console.WriteLine($"Не удалось сконвертировать {number}, попробуйте ещё раз.");
                    Console.Write("Ввод: ");
                    numberInput = Console.ReadLine();
                    result = int.TryParse(numberInput, out number);
                }
            }

            return number;
        }
    }
}
