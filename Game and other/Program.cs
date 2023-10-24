using System;

namespace Game_and_other
{
    internal class Program
    {
        static void Main()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Выберите действие:\n(1) Угадай число.\n(2) Вывод таблицы умножения.\n(3) Вывод всех делителей числа.\n(4) Выход из приложения");

                int oper = Convert.ToInt32(Console.ReadLine());
                switch (oper)
                {
                    case 1:
                        Game();
                        break;
                    case 2:
                        Tabl();
                        break;
                    case 3:
                        Delit();
                        break;
                    case 4:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Некорректный выбор действия. Пожалуйста, выберите существующий пункт меню.");
                        break;
                }
            }
        }

        static void Game()
        {
            Random rnd = new Random();
            int rnumber = rnd.Next(0, 100);

            Console.WriteLine("Введите число:");
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите число:");
            }

            while (number != rnumber)
            {
                string answer = (number > rnumber) ? "Меньше" : "Больше";
                Console.WriteLine(answer);
                while (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите число:");
                }
            }

            Console.WriteLine("Вы угадали!\n");
        }

        static void Tabl()
        {
            const int size = 10;
            int[,] nums = new int[size, size];

            for (int column = 1; column < size; column++)
            {
                for (int line = 1; line < size; line++)
                {
                    nums[column, line] = column * line;
                    Console.Write(nums[column, line] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        static void Delit()
        {
            Console.WriteLine("Введите число:");
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите число:");
            }

            for (int oper = 1; oper <= number; oper++)
            {
                if (number % oper == 0)
                    Console.Write(oper + " ");
            }

            Console.WriteLine("\n");
        }
    }
}