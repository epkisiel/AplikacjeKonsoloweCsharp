using System;

public class Zadanie
{
    public static void Main(string[] args)
    {
        int liczba;
        string wpisaneDane;
        do
        {
            Console.Write("Podaj liczbę całkowitą z przedziału od 10 do 99: ");
            wpisaneDane = Console.ReadLine();
        }while(!int.TryParse(wpisaneDane,out liczba) || liczba<10 || liczba>99);

        if (liczba % 2 == 0)
        {
            Console.WriteLine("Podana liczba jest parzysta.");
        }
        else
        {
            Console.WriteLine("Podana liczba jest nieparzysta.");
        }
    }
}