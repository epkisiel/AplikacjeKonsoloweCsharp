using System;

public class Zadanie
{
    static int PoliczLiczbyPierwsze(bool[] czyPierwsza)
    {
        int ileLiczbPierwszych = 0;
        for(int i = 2; i < czyPierwsza.Length; i++)
        {
            if (czyPierwsza[i])
            {
                ileLiczbPierwszych++;
            }
        }

        return ileLiczbPierwszych;
    }

    static void WykonajSito(bool[] czyPierwsza)

    {

        int n = czyPierwsza.Length - 1; // największa badana liczba 



        // Na początku zakładamy, że każda liczba od 2 w górę jest pierwsza 

        for (int i = 2; i <= n; i++)

        {

            czyPierwsza[i] = true;

        }



        // Dla każdej liczby pierwszej wykreślamy jej wielokrotności 

        for (int i = 2; i * i <= n; i++)

        {

            if (czyPierwsza[i])

            {

                for (int wielokrotnosc = i * i; wielokrotnosc <= n; wielokrotnosc += i)

                {

                    czyPierwsza[wielokrotnosc] = false; // liczba złożona 

                }

            }

        }

    }

    static void Main()
    {
        const int N = 100;

        bool[] czyPierwsza = new bool[N + 1]; // indeksy od 0 do 100 



        WykonajSito(czyPierwsza);



        Console.WriteLine($"Liczby pierwsze w przedziale od 2 do {N}:");

        for (int liczba = 2; liczba <= N; liczba++)

        {

            if (czyPierwsza[liczba])

            {

                Console.Write(liczba + " "); // separatorem jest spacja 

            }

        }

        Console.WriteLine("\nLiczb piewszych w tym przedziale jest " + PoliczLiczbyPierwsze(czyPierwsza));



        Console.WriteLine();

        Console.ReadKey();
    }
} 
