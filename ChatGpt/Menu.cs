using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ChatGpt;

public class Menu
{

    public const string time1 = "15:00";
    public const string time2 = "17:00";
    public const string time3 = "19:00";
    public const string time4 = "21:00";
    public const string time5 = "23:00";
    public static void SnowMenyPrint()
    {
        Console.WriteLine("**********************");
        Console.WriteLine("*                    *");
        Console.WriteLine("*       Hello        *");
        Console.WriteLine("* Welcome Cinematika *");
        Console.WriteLine("*                    *");
        Console.WriteLine("**********************");
        Thread.Sleep(3000);
        Console.Clear();
    }
    public static void ShowAvichaPrint()
    {
        Console.WriteLine(" ********************************************************* ");
        Console.WriteLine("*   Не пропустите 31 декабря скидки 50% на все билеты ;)  *");
        Console.WriteLine(" ********************************************************* ");
        Console.WriteLine("");
    }

    public static void TimeReservationTicket(int index, List<string> movies)
    {
        Console.Clear();
        ShowAvichaPrint();
        Console.WriteLine($"фильм - 1: {movies[index]}  {time1}");
        Console.WriteLine($"фильм - 2: {movies[index]}  {time2}");
        Console.WriteLine($"фильм - 3: {movies[index]}  {time3}");
        Console.WriteLine($"фильм - 4: {movies[index]}  {time4}");
        Console.WriteLine($"фильм - 5: {movies[index]}  {time5}");
        Movie.PrintMovieReservat();
        Movie.MovieReservation(index);
    }

    public static void ExedMenu()
    {
        Environment.Exit(0);
    }


}
