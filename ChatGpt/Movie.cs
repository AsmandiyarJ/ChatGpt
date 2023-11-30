using ChatGpt.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ChatGpt
{
    public class Movie
    {
        public static List<string> Movies =new List<string>();
        public static List<string> Times = new List<string>();


        public static List<string> list = new List<string>
        {
            "Harry Potter 3d",
            "Avatar 2 imax",
            "Home Alone 3d",
            "After 3 3d",
            "Оплата",
            "Ваши брони",
            "Выход"
        };

        public static List<string>  Afisha = new List<string>
        {

        };
        public static void MovieReservation(int index)
        {

            string? s = Console.ReadLine();
            int input = int.Parse(s);

            switch (input)
            {
                case 1:
                    BroniTicket(list,Menu.time1, index);
                    break;
                case 2:
                    BroniTicket(list,Menu.time2, index);
                    break;
                case 3:
                    BroniTicket(list, Menu.time3, index);
                    break;
                case 4:
                    BroniTicket(list, Menu.time4, index);
                    break;
                case 5:
                    BroniTicket(list, Menu.time5, index);
                    break;
                default:
                    Console.WriteLine("Введите от 1 до 5");
                    MovieReservation(0);
                    break;
            }

        }
        public static void PrintMovieReservat()
        {
            Console.WriteLine("");
            Console.WriteLine("Выбери время Когда хотите забранировать :");
            Console.WriteLine("");
            Console.WriteLine("Например 1 ; 2");
        }
        public static void BroniTicket(List<string> movie,string time,int index)
        {
            Console.Clear();
            Menu.ShowAvichaPrint();
            Console.WriteLine("");
            Movies.Add(movie[index]);
            Times.Add(time);
            Console.WriteLine($"Вы забронировали фильм : {movie[index]} в {time}");
            PrintAgainEnter();
        }
        public static void PrintTicketMenu()
        {
            int num = 1;
            Console.Clear();
            for (int i = 0; i < Movies.Count; i++)
            {
                Console.WriteLine($"{num} - {Movies[i]} время {Times[i]}");
                num++;
            }
            PrintAgainEnter();
        }

        public static void PrintAgainEnter()
        {
            Console.WriteLine("");
            Console.WriteLine("нажмите любую клаавишу чтоб вернуться в меня");
            Console.ReadKey();
            MenuAgain.MenuAgainPrint();
        }
    }
}
