using System;

public class Zadanie
{
    // Metoda wypełnia przekazaną tablicę sześcioma liczbami od 1 do 49. 

    static void WypelnijZestaw(int[] liczby, Random generator)

    {

        for (int i = 0; i < liczby.Length; i++)

        {

            liczby[i] = generator.Next(1, 50); // liczba od 1 do 49 

        }

    }



    // Metoda wyświetla pojedynczy zestaw wraz z jego numerem. 

    static void WyswietlZestaw(int numer, int[] liczby)

    {

        Console.Write($"Zestaw {numer}: ");

        foreach (int liczba in liczby)

        {

            Console.Write(liczba + " ");

        }

        Console.WriteLine();

    }

    static int IleParzystych(int[] liczby)
    {
        int ileParzystych = 0;
        for(int i = 0;i < liczby.Length;i++)
        {
            if (liczby[i] % 2 == 0)
            {
                ileParzystych++;
            }
        }
        return ileParzystych;
    }



    static void Main(string[] args)

    {

        Random generator = new Random();



        Console.Write("Ile zestawów wylosować? ");

        int n = int.Parse(Console.ReadLine());



        // Metoda Main steruje przebiegiem, szczegóły kryją się w metodach. 

        for (int zestaw = 1; zestaw <= n; zestaw++)

        {

            int[] liczby = new int[6];   // tablica na jeden zestaw 

            WypelnijZestaw(liczby, generator); // metoda wypełnia tablicę 

            WyswietlZestaw(zestaw, liczby);  // metoda wyświetla zestaw 

            Console.WriteLine("Liczba elementów parzystych w zestawie: " + IleParzystych(liczby)+"\n");

        }



        Console.ReadKey();

    }
} 
