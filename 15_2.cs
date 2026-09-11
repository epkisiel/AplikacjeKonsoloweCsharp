using System;
using System.IO;

public class Zadanie
{
    static int wyznaczNajmniejsza(int[] liczby)
    {
        /*************
        nazwa funkcji: wyznaczNajmniejsza
        opis: szuka najmniejszej liczby z tablicy
        parametry: liczby - tablica liczb z której wyszukiwana będzie ta najmniejsza
        zwracana wartość: zwracana jest najmniejsza liczba (zmienna typu int)
        autor: 1
        *************/
        int najmniejsza = liczby[0];
        for (int i = 0; i < liczby.Length; i++)
        {
            if (liczby[i] < najmniejsza)
            {
                najmniejsza = liczby[i];
            }
        }
        return najmniejsza;
    }

    public static void Main(string[] args)
    {
        int[] liczby = { 12, 7, 25, 3, 18 };
        int najmniejsza= wyznaczNajmniejsza(liczby);

        Console.WriteLine("Najmniejsza liczba to "+najmniejsza);
    }
}