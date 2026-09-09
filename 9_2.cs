using System;

public class Zadanie
{
    static int Najwiekszy(int[] liczby)
    {
        int najwieksza = liczby[0];
        for(int i=1;i<liczby.Length;i++)
        {
            if (najwieksza < liczby[i])
            {
                najwieksza = liczby[i];
            }
        }
        return najwieksza;
    }

    public static void Main(string[] args)
    {
        int[] liczby = { 4, 5, 1, 7, 4, 2 };
        Console.WriteLine(Najwiekszy(liczby));
    }
}