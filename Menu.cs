using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_GB
{
    internal class Menu
    {
        /// <summary>
        /// Get Homework menu(test with string[])
        /// </summary>
        internal static void HomeworkMenu() //TODO Try to make it with LIST!!!
        {
            string[] menuItems = new string[] { "Lesson1_1", "Lesson1_2", "Lesson1_3", "Lesson2", "Выход" };

            int row = Console.CursorTop;
            int col = Console.CursorLeft;
            int index = 0;

            while (true)
            {
                DrawMenu(menuItems, row, col, index);
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.DownArrow:
                        if (index < menuItems.Length - 1)
                            index++;
                        break;

                    case ConsoleKey.UpArrow:
                        if (index > 0)
                            index--;
                        break;

                    case ConsoleKey.Enter:
                        Console.Clear();
                        DrawMenu(menuItems, row, col, index);
                        switch (index)
                        {
                            case 0:
                                InputOutput.Lesson1_1();
                                break;

                            case 1:
                                InputOutput.Lesson1_2();
                                break;

                            case 2:
                                InputOutput.Lesson1_3();
                                break;

                            case 3:
                                InputOutput.Lesson2();
                                break;

                            case 4:
                                {
                                    Console.WriteLine("Exit program");
                                    Environment.Exit(0);
                                }
                                break;
                        }
                        break;
                }
            }
        }

        /// <summary>
        /// Draw Homework menu(test)
        /// </summary>
        /// <param name="items"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="index"></param>
        private static void DrawMenu(string[] items, int row, int col, int index)
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(col, row);
            Console.WriteLine("HOMEWORK MENU:");
            Console.WriteLine();

            for (int i = 0; i < items.Length; i++)
            {
                if (i == index)
                {
                    Console.BackgroundColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.WriteLine(items[i]);
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }
}
