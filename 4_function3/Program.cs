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

            Console.Write("Введите число: ");
            numberInput = Console.ReadLine();

            result = int.TryParse(numberInput, out number);

            while (canExitApp)
            {
                if (result)
                {
                    Console.Write($"Число успешно сконвертировано! - {number}");
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
        }
    }
}       
