using System;
using System.IO;

public class Zadanie
{
    static int wczytajLiczbeUczniow()
    {
        string wpisane;
        int liczbaUczniow;
        do
        {
            Console.Write("Podaj liczbę uczniów: ");
            wpisane = Console.ReadLine();
        } while (!int.TryParse(wpisane, out liczbaUczniow) || liczbaUczniow < 0);

        return liczbaUczniow;
    }

    static int[] wczytajWyniki(int liczbaUczniow)
    {
        /*************
        nazwa funkcji: wczytajWyniki
        opis: wczytuje od użytkownika wyniki z testu
        parametry: liczbaUczniow - liczba uczniów zdających test
        zwracana wartość: zmienna wyniki typu int - wyniki testu wpisane przez użytkownika
        autor: 1
        *************/
        int[] wyniki = new int[liczbaUczniow];
        string wpisane;
        for (int i = 0; i < wyniki.Length; i++)
        {
            do
            {
                Console.Write("Podaj wynik " + (i + 1) + " ucznia (0-100): ");
                wpisane = Console.ReadLine();
            } while (!int.TryParse(wpisane, out wyniki[i]) || wyniki[i] < 0 || wyniki[i] > 100);
        }

        return wyniki;
    }

    static void podsumowanie(int[] wyniki)
    {
        double srednia = 0;
        int ileZaliczylo = 0;
        for(int i = 0;i < wyniki.Length; i++)
        {
            srednia += wyniki[i];
            if (wyniki[i] >= 50)
            {
                ileZaliczylo++;
            }
        }
        srednia = srednia / wyniki.Length;

        Console.WriteLine("Średni wynik klasy to " + srednia+".");
        Console.WriteLine("Test zaliczyło " + ileZaliczylo + " osób.");
    }

    public static void Main(string[] args)
    {
        int liczbaUczniow=wczytajLiczbeUczniow();

        int[] wyniki = wczytajWyniki(liczbaUczniow);

        podsumowanie(wyniki);
    }
}