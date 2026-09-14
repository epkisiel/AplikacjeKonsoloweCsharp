using System;

public class Zadanie
{

    static void Main()
    {
        Console.WriteLine("Wpisz zdanie: ");
        string zdanie = Console.ReadLine();
        string[] slowa = zdanie.Split(' ');

        Console.WriteLine("Liczba słów w zdaniu: " + slowa.Length);
        Console.WriteLine(zdanie.ToUpper());
    }
} 
