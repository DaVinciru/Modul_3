using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Modul_3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Основное меню. Переменные

            string head_menu = "Основное меню";
            string head_game = "Игра в цифры";
            int dif_level;
            string dif_level_txt = "Уровень сложности: ";
            string level_txt = "Уровень сложности";
            string var_dif_level = $"{dif_level_txt}" + $"{level_txt}";

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
            Console.WriteLine($"Ваш никнейм  \n \"{nick_p1}\"");
            Console.SetCursorPosition(Console.WindowWidth - var_dif_level.Length, 0);
            Console.WriteLine($"{var_dif_level}");
            #endregion

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition((Console.WindowWidth / 2) - (head_menu.Length / 2), 4);
            Console.WriteLine(head_menu);

            Console.ResetColor();
            Console.WriteLine("1. Уровень сложности.");
            Console.WriteLine("2. Один против ИИ.");
            Console.WriteLine("3. Два игрока.");
            Console.WriteLine("4. Правила игры.");



            int gameMenu;



            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Выберите режим игры");
                Console.ResetColor();
                gameMenu = Int32.Parse(Console.ReadLine());

                if (gameMenu >= 1 && gameMenu <= 4)
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
                    Console.WriteLine("Уровень сложности: ");
                    Console.WriteLine("Выберите уровень сложности: \n 1 - Легко \n 2 - Сложно");
                    dif_level = Int32.Parse(Console.ReadLine());
                    while (true)
                    {
                        // Выводим в столбик следующие надписи и ждем далее ввода пользователя (иначе цикл будет бесконечным)
                        Console.WriteLine("Выберите уровень сложности: \n 1 - Легко \n 2 - Сложно");
                        
                        dif_level = Int32.Parse(Console.ReadLine());

                        if (dif_level >= 1 && dif_level <= 2)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Выберите уровень сложности 1 или 2");
                        }
                    }

                    
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



            //   

            //    Console.WriteLine("1. Уровень сложности." + $"{dif_level}");
            //    Console.WriteLine("2. Один против ИИ.");
            //    Console.WriteLine("3. Два игрока.");
            //    Console.WriteLine("4. Правила игры.");

            //    Console.ReadKey();


            #endregion
            //}
        }
    }
}
