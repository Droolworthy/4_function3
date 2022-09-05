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
            bool result;

            Console.Write("Введите номер: ");
            numberInput = Console.ReadLine();

            result = int.TryParse(numberInput, out number);

            ConvertNumber(numberInput, number, result, canExitApp);
        }

        static int ConvertNumber(string numberInput, int number, bool result, bool canExitApp)
        {
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
