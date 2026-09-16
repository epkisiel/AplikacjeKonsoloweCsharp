using System;

public class Zadanie
{
    static int WczytajDane(string komunikat, int min, int max)
    {
        string wpisane;
        int poprawneDane;

        do
        {
            Console.Write(komunikat);
            wpisane = Console.ReadLine();
            if (!int.TryParse(wpisane, out poprawneDane))
            {
                Console.WriteLine("Błąd: podano wartość, która nie jest liczbą.");
            }
            if (poprawneDane < min || poprawneDane > max)
            {
                Console.WriteLine("Błąd: podana liczba nie jest z zakresu " + min + "-" + max);
            }
        } while (!int.TryParse(wpisane, out poprawneDane) || poprawneDane < min || poprawneDane > max);

        return poprawneDane;
    }

    static int WyznaczNajnizsza(int[] oceny)
    {
        /*********************
        nazwa funkcji: WyznaczNajnizsza
        opis funkcji: wyznacza najniższą ocenę
        parametry: tablica liczb całkowitych (int[]) oceny - zawiera oceny uczniów
        zwracana wartość: liczba całkowita (int) najnizsza - zwracana jest najniższa ocena
        autor: 25
        *********************/

        int najnizsza = oceny[0];
        foreach(int ocena in oceny)
        {
            if(ocena< najnizsza)
            {
                najnizsza=ocena;
            }
        }
        return najnizsza;
    }
    static int WyznaczNajwyzsza(int[] oceny)
    {
        int najwyzsza = oceny[0];
        foreach (int ocena in oceny)
        {
            if (ocena > najwyzsza)
            {
                najwyzsza = ocena;
            }
        }
        return najwyzsza;
    }

    static double ObliczSrednia(int[] oceny)
    {
        int suma = 0;
        foreach(int ocena in oceny)
        {
            suma += ocena;
        }
        double srednia=(double)suma / oceny.Length;
        return Math.Round(srednia * 100) / 100;
    }

    static int PoliczNiedostateczne(int[] oceny)
    {
        int ileNiedostatecznych = 0;
        foreach (int ocena in oceny)
        {
            if (ocena == 1)
            {
                ileNiedostatecznych++;
            }
        }
        return ileNiedostatecznych;
    }

    static void Main()
    {
        Console.WriteLine("System rejestracji ocen klasowych\n");

        int liczbaUczniow = WczytajDane("Podaj liczbę uczniów: ", 1, 40);

        int[] oceny = new int[liczbaUczniow];
        for(int i = 0; i < liczbaUczniow; i++)
        {
            oceny[i] = WczytajDane($"Podaj ocenę {i+1} ucznia: ", 1, 6);
        }

        Console.WriteLine("");
        Console.WriteLine("Ocena najwyższa: " + WyznaczNajwyzsza(oceny));
        Console.WriteLine("Ocena najniższa: "+WyznaczNajnizsza(oceny));
        Console.WriteLine("Średnia ocen: " + ObliczSrednia(oceny));
        Console.WriteLine("Liczba ocen niedostatecznych: " + PoliczNiedostateczne(oceny));
    }
} 
