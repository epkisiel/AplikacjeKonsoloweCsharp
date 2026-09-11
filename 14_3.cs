using System;
using System.IO;

public class Zadanie
{
    static void zapisywanie()
    {
        Random losowanie = new Random();

        using (StreamWriter zapis = new StreamWriter("losowe.txt"))
        {
            for (int i = 0; i < 10; i++)
            {
                zapis.WriteLine(losowanie.Next(1, 101));
            }
        }
    }

    static void odczytywanie()
    {
        using (StreamReader odczyt = new StreamReader("losowe.txt"))
        {
            if (File.Exists("losowe.txt"))
            {
                try
                {
                    string linia;
                    int najmniejsza = 100;
                    int najwieksza = 1;
                    int suma = 0;

                    Console.WriteLine("Wylosowane liczby: ");
                    while ((linia = odczyt.ReadLine()) != null)
                    {
                        Console.WriteLine(linia);
                        suma += int.Parse(linia);
                        if (najwieksza < int.Parse(linia))
                        {
                            najwieksza = int.Parse(linia);
                        }
                        if (najmniejsza > int.Parse(linia))
                        {
                            najmniejsza = int.Parse(linia);
                        }
                    }

                    Console.WriteLine("\nSuma wszystkich liczb to " + suma);
                    Console.WriteLine("Najmniejsza liczba to " + najmniejsza);
                    Console.WriteLine("Największa liczba to " + najwieksza);
                }
                catch (IOException)
                {
                    Console.WriteLine("Wystąpił błąd podczas odczytu pliku.");
                }
            }
        }
    }

    public static void Main(string[] args)
    {
        zapisywanie();

        odczytywanie();
    }
}