using System;
using System.Net.NetworkInformation;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Zadanie
{
    static int ZnajdzNajczestszaLiczbe(int[] liczniki)
    {
        /**********************************************
        *Nazwa funkcji: ZnajdzNajczestszaLiczbe
        * Opis działania: szuka najczęściej wylosowanej liczby
        * Parametry: int[] liczniki - tablica z której będzie wyszukiwana liczba
        * Zwracana wartość: liczba całkowita dodatnia(int) - wyszukana liczba
        * Autor: numer zdającego
        **********************************************/
        int najczestsza = liczniki.Length-1;
        for(int i = liczniki.Length-1; i > 0; i--)
        {
            if (liczniki[i] >= liczniki[najczestsza])
            {
                najczestsza = i;
            }
        }

        return najczestsza;
    }

    // Stałe opisujące reguły loterii — dzięki nim unikamy "magicznych liczb" w kodzie 

    const int LiczbWZestawie = 6; // ile liczb ma jeden zestaw 

    const int MinWartosc = 1;  // najmniejsza losowana liczba 

    const int MaxWartosc = 49;  // największa losowana liczba 



    static void Main()

    {

        Console.WriteLine("=== Loteria liczbowa ===");



        // Krok 1: pobranie liczby zestawów od użytkownika 

        int liczbaZestawow = WczytajLiczbeZestawow();



        // Krok 2: utworzenie tablicy dwuwymiarowej n wierszy na 6 kolumn 

        int[,] zestawy = new int[liczbaZestawow, LiczbWZestawie];



        // Krok 3: jeden generator liczb pseudolosowych dla całego programu 

        Random generator = new Random();



        // Krok 4: wypełnienie tablicy wylosowanymi liczbami 

        WypelnijZestawy(zestawy, generator);



        // Krok 5: wyświetlenie wszystkich wylosowanych zestawów 

        WyswietlZestawy(zestawy);



        // Krok 6: policzenie i wyświetlenie wystąpień liczb od 1 do 49 

        int[] liczniki = PoliczWystapienia(zestawy);

        WyswietlWystapienia(liczniki);

        Console.WriteLine("Najczestsza liczba: "+ZnajdzNajczestszaLiczbe(liczniki));

        Console.WriteLine("\nNaciśnij dowolny klawisz, aby zakończyć…");

        Console.ReadKey();

    }



    /********************************************** 

    * Nazwa funkcji: WczytajLiczbeZestawow 

    * Opis działania: pobiera od użytkownika dodatnią liczbę całkowitą 

    *     oznaczającą liczbę zestawów do wylosowania 

    * Parametry: brak 

    * Zwracana wartość: liczba całkowita dodatnia (int) 

    * Autor: numer zdającego 

    **********************************************/

    static int WczytajLiczbeZestawow()

    {

        int liczba;

        bool poprawne;



        // Pętla powtarza się, dopóki użytkownik nie poda poprawnej liczby dodatniej 

        do

        {

            Console.Write("Podaj liczbę zestawów do wylosowania: ");

            string wejscie = Console.ReadLine();



            // int.TryParse zwraca true, gdy tekst da się zamienić na liczbę 

            poprawne = int.TryParse(wejscie, out liczba) && liczba > 0;



            if (!poprawne)

            {

                Console.WriteLine("Błąd: należy podać liczbę całkowitą większą od zera.");

            }

        } while (!poprawne);



        return liczba;

    }



    // Wypełnia przekazaną tablicę zestawami sześciu liczb bez powtórzeń w obrębie wiersza 

    static void WypelnijZestawy(int[,] zestawy, Random generator)

    {

        int liczbaZestawow = zestawy.GetLength(0); // liczba wierszy 



        for (int wiersz = 0; wiersz < liczbaZestawow; wiersz++)

        {

            for (int kolumna = 0; kolumna < LiczbWZestawie; kolumna++)

            {

                int wylosowana;



                // Losujemy tak długo, aż trafimy na liczbę, której nie ma jeszcze w wierszu 

                do

                {

                    // Next(min, max) zwraca liczbę z przedziału <min, max), stąd MaxWartosc + 1 

                    wylosowana = generator.Next(MinWartosc, MaxWartosc + 1);

                } while (CzyZawiera(zestawy, wiersz, kolumna, wylosowana));



                zestawy[wiersz, kolumna] = wylosowana;

            }

        }

    }



    // Sprawdza, czy wartość znajduje się już w danym wierszu do pozycji "ileWypelnione" 

    static bool CzyZawiera(int[,] zestawy, int wiersz, int ileWypelnione, int wartosc)

    {

        for (int kolumna = 0; kolumna < ileWypelnione; kolumna++)

        {

            if (zestawy[wiersz, kolumna] == wartosc)

            {

                return true;

            }

        }

        return false;

    }



    // Wyświetla na ekranie wszystkie wylosowane zestawy 

    static void WyswietlZestawy(int[,] zestawy)

    {

        int liczbaZestawow = zestawy.GetLength(0);



        Console.WriteLine("\nWylosowane zestawy:");

        for (int wiersz = 0; wiersz < liczbaZestawow; wiersz++)

        {

            Console.Write($"Zestaw {wiersz + 1}: ");

            for (int kolumna = 0; kolumna < LiczbWZestawie; kolumna++)

            {

                // {0,2} oznacza wyrównanie liczby do dwóch znaków, dla czytelności kolumn 

                Console.Write($"{zestawy[wiersz, kolumna],3}");

            }

            Console.WriteLine();

        }

    }



    // Zlicza wystąpienia każdej liczby od 1 do 49 we wszystkich zestawach 

    static int[] PoliczWystapienia(int[,] zestawy)

    {

        // Tablica o rozmiarze 50: indeks odpowiada wartości liczby (indeks 0 pozostaje nieużywany) 

        int[] liczniki = new int[MaxWartosc + 1];



        int liczbaZestawow = zestawy.GetLength(0);

        for (int wiersz = 0; wiersz < liczbaZestawow; wiersz++)

        {

            for (int kolumna = 0; kolumna < LiczbWZestawie; kolumna++)

            {

                int wartosc = zestawy[wiersz, kolumna];

                liczniki[wartosc]++; // zwiększamy licznik dla tej konkretnej wartości 

            }

        }



        return liczniki;

    }



    // Wyświetla tabelę wystąpień liczb od 1 do 49 

    static void WyswietlWystapienia(int[] liczniki)

    {

        Console.WriteLine("\nWystąpienia poszczególnych liczb:");

        for (int liczba = MinWartosc; liczba <= MaxWartosc; liczba++)

        {

            Console.WriteLine($"Liczba {liczba,2}: {liczniki[liczba]} wystąpień");

        }

    }

} 
