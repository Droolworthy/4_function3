//Написать функцию, которая запрашивает число у пользователя (с помощью метода Console.ReadLine() ) 
//и пытается сконвертировать его в тип int (с помощью int.TryParse())
//Если конвертация не удалась у пользователя запрашивается число повторно до тех пор, пока не будет введено верно. 
//После ввода, который удалось преобразовать в число, число возвращается.
//P.S Задача решается с помощью циклов
//P.S Также в TryParse используется модфикатор параметра out
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
