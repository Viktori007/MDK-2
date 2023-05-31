using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Вариант №7 (Направления)
Строковому меню предшествует центрированная надпись: «Выберите направление движения из списка:». Надпись не участвует 
в «пролистывании» пунктов меню. В качестве пунктов меню предложить: «вверх», «влево», «вниз», «вправо». Реализовать маркировку 
соответствующих пунктов по нажатии на стрелочные клавиши на клавиатуре. Выход из меню предусмотреть по нажатии клавиши «Esc». 
Подтверждение выбранного пункта меню реализовать по клавише «Enter».
 */


namespace guru
{
    class Program
    {
        static string[] menu = { "1. вверх", "2. вниз", "3. влево", "4. вправо" };//массив 
        static int i = -1;//текущий индекс в массиве
        static ConsoleKeyInfo keyInfo;

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;// цвета
            Console.Clear();

            Console.WriteLine("Выберите направление движения из списка:");

            while (true)
            {
                DrawMenu();//вызываем функцию
                keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.UpArrow)// если стрелка вверх
                    i = 0;

                else if (keyInfo.Key == ConsoleKey.DownArrow)//ели стрелка вниз
                    i = 1;

                else if (keyInfo.Key == ConsoleKey.LeftArrow)// если стрелка вдево
                    i = 2;

                else if (keyInfo.Key == ConsoleKey.RightArrow)// если стрелка вправо
                    i = 3;

                else if (keyInfo.Key == ConsoleKey.Enter)//при нажатии ввода, выбирается выделенное
                {
                    if (i >= 0)
                    {
                        Console.WriteLine("\nВыбран пункт меню: " + menu[i]);
                        Console.WriteLine("Нажмите любую клавишу для продолжения...");
                        Console.ReadKey();
                    }
                }
                else if (keyInfo.Key == ConsoleKey.Escape)//завершаем,если нажат esc
                    break;
            }
        }

        static void DrawMenu()
        {
            Console.Clear();//очищаем консоль
            Console.WriteLine("Выберите направление движения из списка:");

            for (int j = 0; j < 4; j++)//проверяем на совпадение
            {
                if (j == i)//если да
                {
                    Console.BackgroundColor = ConsoleColor.Red;//выделяем красным
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;//в ином случае текст остается на черном фоне
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.WriteLine(menu[j]);
            }
        }
    }
}
