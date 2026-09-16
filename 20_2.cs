using System;

public class Zadanie
{
    /* 

  * Nazwa funkcji: WczytajLiczbe 

  * Opis: Wczytuje od uzytkownika liczbe calkowita z podanego zakresu. 

  *  Powtarza prosbe az do podania poprawnej wartosci, obslugujac 

  *  zarowno bledny format, jak i wartosc spoza zakresu. 

  * Parametry: 

  * komunikat – tekst zachety wyswietlany uzytkownikowi 

  * min – dolna granica dozwolonego zakresu 

  * max – gorna granica dozwolonego zakresu 

  * Zwracana wartosc: poprawna liczba calkowita z zakresu min–max 

  * Autor: zdajacy nr 25 

  */

    static int WczytajLiczbe(string komunikat, int min, int max)

    {

        while (true)

        {

            Console.Write(komunikat);

            string wejscie = Console.ReadLine();



            // Najpierw sprawdzamy, czy to w ogole liczba 

            if (!int.TryParse(wejscie, out int liczba))

            {

                Console.WriteLine("Blad: wprowadzona wartosc nie jest liczba.");

                continue;

            }



            // Nastepnie sprawdzamy zakres 

            if (liczba < min || liczba > max)

            {

                Console.WriteLine("Blad: wartosc musi miescic sie w zakresie " + min + " do " + max + ".");

                continue;

            }



            return liczba; // poprawna wartosc konczy funkcje 

        }

    }



    // Funkcja oblicza srednia arytmetyczna pomiarow z listy 

    static double ObliczSrednia(List<int> pomiary)

    {

        int suma = 0;

        foreach (int pomiar in pomiary)

            suma += pomiar;



        // Rzutowanie na double zapewnia dokladny wynik 

        return (double)suma / pomiary.Count;

    }



    // Funkcja liczy dni mrozne, czyli pomiary ponizej zera 

    static int PolicznDniMrozne(List<int> pomiary)

    {

        int mrozne = 0;

        foreach (int pomiar in pomiary)

        {

            if (pomiar < 0)

                mrozne++;

        }

        return mrozne;

    }

    static int PoliczDniCieple(List<int> pomiary)
    {
        int cieple = 0;
        foreach (int pomiar in pomiary)
        {
            if (pomiar>25)
                cieple++;
        }

        return cieple;
    }

    static void Main()

    {

        Console.WriteLine("=== System rejestracji pomiarow temperatury ===");



        // Wczytujemy liczbe pomiarow z dozwolonego zakresu 

        int liczbaPomiarow = WczytajLiczbe("Podaj liczbe pomiarow (1–31): ", 1, 31);



        // Kolekcja przechowujaca wszystkie pomiary 

        List<int> pomiary = new List<int>();



        // Wczytujemy kolejne pomiary z walidacja zakresu 

        for (int i = 1; i <= liczbaPomiarow; i++)

        {

            int temperatura = WczytajLiczbe("Podaj pomiar nr " + i + " (–50 do 50): ", -50, 50);

            pomiary.Add(temperatura);

        }



        // Wyznaczamy maksimum i minimum 

        int najwyzsza = pomiary[0];

        int najnizsza = pomiary[0];

        foreach (int pomiar in pomiary)

        {

            if (pomiar > najwyzsza) najwyzsza = pomiar;

            if (pomiar < najnizsza) najnizsza = pomiar;

        }



        // Korzystamy z funkcji do pozostalych obliczen 

        double srednia = ObliczSrednia(pomiary);

        int dniMrozne = PolicznDniMrozne(pomiary);

        int dniCieple=PoliczDniCieple(pomiary);



        // Wyswietlamy czytelne podsumowanie 

        Console.WriteLine();

        Console.WriteLine("=== Podsumowanie pomiarow ===");

        Console.WriteLine("Temperatura najwyzsza: " + najwyzsza + " st.");

        Console.WriteLine("Temperatura najnizsza: " + najnizsza + " st.");

        Console.WriteLine("Temperatura srednia: " + srednia.ToString("F2") + " st.");

        Console.WriteLine("Liczba dni mroznych: " + dniMrozne);

        Console.WriteLine("Liczba dni ciepłych: " + dniCieple);

    }
} 
