using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGpt
{
    public static class MenuAgain
    {
        public static void NavigationMenu(int index, List<string> select)
        {

            Console.Clear();
            Menu.ShowAvichaPrint();

            foreach (var rasd in select)
            {

                if (rasd == select[index])
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine(" >> " + rasd);


                }
                else
                {
                    Console.WriteLine(" " + rasd);
                }

                Console.ResetColor();

            }
        }

        public static void AddList(List<string> list)
        {

            int index = 0;

            NavigationMenu(index, list);
            ConsoleKeyInfo key;

            do
            {

                key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.DownArrow && index + 1 < list.Count)
                {
                    if (index > list.Count)
                    {
                        index--;
                    }
                    index++;
                    NavigationMenu(index, list);

                }
                else if (key.Key == ConsoleKey.UpArrow && index - 1 >= 0)
                {
                    index--;
                    NavigationMenu(index, list);

                }
                else if (key.Key == ConsoleKey.Enter && index == 4)
                {
                    Movie.PrintTicketMenu();
                }
                else if (key.Key == ConsoleKey.Enter && index == 5)
                {
                    Menu.ExedMenu();
                }
                else if (key.Key == ConsoleKey.Enter && index + 1 < list.Count)
                {
                    Menu.TimeReservationTicket(index, list);

                }

            } while (key.Key != ConsoleKey.Enter);

            Console.ReadKey();

        }
        public static void MenuAgainPrint()
        {
            NavigationMenu(0, Movie.list);
            AddList(Movie.list);
        }
    }
}
