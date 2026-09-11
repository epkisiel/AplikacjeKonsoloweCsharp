using System;

public class Zadanie
{
    static List<int> liczby = new List<int>();

    public static int wczytywanieOcen(string wpisane)
    {
        if (int.TryParse(wpisane, out int liczba) && liczba >= 1 && liczba <= 6)
        {
            liczby.Add(liczba);
            return liczba;
        }
        else
        {
            Console.WriteLine("Należy podać ocenę w skali od 1 do 6.");
            return 0;
        }
    }


    public static void Main(string[] args)
    {
        
        string wpisane="";
        double srednia=0;
        while (wpisane != "koniec")
        {
            Console.Write("Podaj ocenę: ");
            wpisane = Console.ReadLine();
            if(wpisane != "koniec")
            {
                srednia+=wczytywanieOcen(wpisane);
            }
        }

        Console.WriteLine("Liczba wprowadzonych ocen: " + liczby.Count);
        srednia = srednia / liczby.Count;
        Console.WriteLine("Średnia ocen: " + srednia);
    }
}