using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_3
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Выбирите режим игры");

            Console.WriteLine("1. Уровень сложности.");
            Console.WriteLine("2. Один против ИИ.");
            Console.WriteLine("3. Два игрока.");
            Console.WriteLine("4. Правила игры.");



            int gameMenu;



            while (true)
            {
                Console.WriteLine("Выберите режим игры");
                gameMenu = Int32.Parse(Console.ReadLine());

                if (gameMenu >=1 && gameMenu <= 4)
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Введите число от 1 до 4");
                }
                
            }

            switch (gameMenu)
            {
                case 1:
                    Console.WriteLine("Игра 1");
                    break;

                case 2:
                    Console.WriteLine("Игра 2");
                    break;

                case 3:
                    Console.WriteLine("Игра 3");
                    break;

                case 4:
                    Console.WriteLine("Игра 4");
                    break;


            }


        }

        static void Menu()
        {
            #region Основное меню, переменные
            // Расположить меню по середине консоли
            // Оформляем вид меню, выводим необходимые значения
            // а также отображаем уровень сложности
            // Задаем переменную заголовка игры и меню, выставляем цвет, положение

            string head_menu = "Основное меню";
            string head_game = "Игра в цифры";
            byte dif_level = 1;
            string dif_level_txt = "Уровень сложности: ";
            string level_txt = "Уровень сложности";
            string var_dif_level = $"{dif_level_txt}" + $"{level_txt}";

            //switch (dificult)
            //{
            //    case dif_level == 1:

            //    default:
            //        break;
            //}
            // Заголовок (название) игры. Задаем синий цвет, выставляем курсор по центру, пишем название игры
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition((Console.WindowWidth / 2) - (head_game.Length / 2), 0);
            Console.WriteLine(head_game);

            // Далее сбрасываем на цвет по умолчанию, выставляем курсор слева с оступом на одну строку по Y, просим ввести никнейм игрока
            Console.ResetColor();
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("Введите ваш никнейм :");

            string nick_p1 = Console.ReadLine();
            //            string nick_p2 = Console.ReadLine();
            Console.SetCursorPosition(0, 1);
            Console.WriteLine($"Ваш никнейм \n\"{nick_p1}\"");
            Console.SetCursorPosition(Console.WindowWidth - var_dif_level.Length, 0);
            Console.WriteLine($"{var_dif_level}");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition((Console.WindowWidth / 2) - (head_menu.Length / 2), 4);
            Console.WriteLine(head_menu);

            Console.WriteLine("1. Уровень сложности." + $"{dif_level}");
            Console.WriteLine("2. Один против ИИ.");
            Console.WriteLine("3. Два игрока.");
            Console.WriteLine("4. Правила игры.");

            Console.ReadKey();


            #endregion
        }
    }
}
