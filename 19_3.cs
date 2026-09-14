using System;

public class Zadanie
{
    static int[] WczytajLiczby()
    {
        /**********************
        nazwa funkcji: WczytajLiczby
        opis: wczytuje od użytkownika 5 liczb
        parametry: brak
        zwracany typ: tablica liczb całkowitych (int) - zwraca podane przez użytkownika liczby
        autor: 7
        **********************/
        int[] liczby = new int[5];
        for(int i = 0; i < 5; i++)
        {
            Console.Write("Podaj liczbę: ");
            string wpisane = Console.ReadLine();
            while(!int.TryParse(wpisane, out liczby[i]))
            {
                Console.Write("Podana wartość jest niepoprawna. Podaj jszcze raz: ");
                wpisane= Console.ReadLine();
            }
        }
        return liczby;
    }
    static void Podsumowanie(int[] liczby)
    {
        int suma = 0;
        int ileDodatnich = 0;
        for (int i = 0; i < liczby.Length; i++)
        {
            suma += liczby[i];
            if (liczby[i] > 0)
            {
                ileDodatnich++;
            }
        }

        Console.WriteLine("Suma liczb wynosi " + suma);
        Console.WriteLine("Liczb dodatnich jest " + ileDodatnich );
    }
    static void Main()
    {
        int[] liczby = WczytajLiczby();
        Podsumowanie(liczby);
    }
} 
