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

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition((Console.WindowWidth / 2) - (head_game.Length / 2), 0);
            Console.WriteLine(head_game);

            Console.ResetColor();
            Console.SetCursorPosition(0,1);
            Console.WriteLine("Введите ваш никнейм:");

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

           
            #endregion
        }
    }
}
