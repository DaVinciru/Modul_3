using System;

namespace ForTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random random = new Random();
            //Console.Write("\n Введите старт:");
            //int start = Convert.ToInt32(Console.ReadLine());

            //Console.Write("\n Введите end:");
            //int end = Convert.ToInt32(Console.ReadLine());

            ////Выводим на экран квадрат чисел с отступом 4 знака. 
            //for (int i = start; i <= end; i++)
            //{
            //    Console.WriteLine($"{i,4}^2 = {i*i}");
            //}
            

            Console.Write("\n Введите Start: ");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n Введите End: ");
            int end = Convert.ToInt32(Console.ReadLine());

            DateTime dt1 = new DateTime();
            dt1 = DateTime.Now;
            Console.WriteLine(dt1);

            while (start <= end)
            {
                Console.WriteLine($"{start,4} ^ 2 = {start * start} ");
                start++;
            }

            DateTime dt2 = new DateTime();
            dt2 = DateTime.Now;
            Console.WriteLine(dt2);
            Console.WriteLine(dt2.Subtract(dt1));
        }
    }
}
