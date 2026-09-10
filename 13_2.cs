using System;

public class Zadanie
{

    public static void Main(string[] args)
    {
        try
        {
            Console.Write("Podaj liczbę całkowitą: ");
            int liczba1 = int.Parse(Console.ReadLine());
            Console.Write("Podaj drugą liczbę całkowitą: ");
            int liczba2 = int.Parse(Console.ReadLine());
            double wynik = liczba1 / liczba2;
            Console.WriteLine("Wynik dzielenia: " + wynik);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Nie można dzielić przez zero.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Podana wartość nie jest liczbą całkowitą.");
        }
        
    }
}