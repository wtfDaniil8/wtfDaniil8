// !!! Created in Visual Studio by amtAtom Company
using System;

namespace project
{
    public static class Program
    {
        static void Main()
        {
            int num_1 = 0, num_2 = 0;
            Console.Write("Введите число 1: ");
            num_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число 2: ");
            num_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выберите что хотите сделать? (+, -, *)");
            string math_operator;
            math_operator = Console.ReadLine();
            int result = 0;
            bool continue_to_write = false;
            if(math_operator == "+")
            {
                result = num_1 + num_2;
                continue_to_write = true;

            }
            else if(math_operator == "-")
            {
                result = num_1 - num_2;
                continue_to_write = true;
            }
            else if(math_operator == "*")
            {
                result = num_1 * num_2;
                continue_to_write = true;
            }
            else
            {
                continue_to_write = false;
            }
            if(continue_to_write == true)
            {
                Console.WriteLine("Результат: " + result);
            }
            else if(continue_to_write = false)//Можно просто  else(...){...}
            {
                Console.WriteLine("Неверный выбор! Нажмите любую клавишу для выхода.");
                Console.ReadKey();
            }
            
        }
    }
}