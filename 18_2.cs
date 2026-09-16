using System;

public class Zadanie
{
    static int Nww(int a, int b)
    {
        return (a * b) / Nwd(a, b);
    }

    static int Nwd(int a, int b)

    {

        // Powtarzamy, dopóki obie liczby nie będą równe 

        while (a != b)

        {

            if (a > b)

            {

                a = a - b; // od większej odejmujemy mniejszą 

            }

            else

            {

                b = b - a;

            }

        }



        return a; // gdy a == b, ta wartość jest największym wspólnym dzielnikiem 

    }



    // Pobiera od użytkownika liczbę całkowitą dodatnią wraz z walidacją 

    static int WczytajLiczbeDodatnia(string komunikat)

    {

        int liczba;

        bool poprawne;



        do

        {

            Console.Write(komunikat);

            poprawne = int.TryParse(Console.ReadLine(), out liczba) && liczba > 0;



            if (!poprawne)

            {

                Console.WriteLine("Błąd: należy podać liczbę całkowitą dodatnią.");

            }

        } while (!poprawne);



        return liczba;

    }
    static void Main()

    {

        Console.WriteLine("=== Największy wspólny dzielnik (algorytm Euklidesa) ===");



        int a = WczytajLiczbeDodatnia("Podaj pierwszą liczbę (a): ");

        int b = WczytajLiczbeDodatnia("Podaj drugą liczbę (b): ");



        int wynik = Nwd(a, b); // wywołanie funkcji obliczeniowej 

        Console.WriteLine($"NWD({a}, {b}) = {wynik}");

        Console.WriteLine($"NWW({a}, {b}) = {Nww(a, b)}");



        Console.ReadKey();

    }


} 
