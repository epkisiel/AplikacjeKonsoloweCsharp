using System;
using System.IO;

public class Zadanie
{

    public static void Main(string[] args)
    {
        string wpisane="";
        do
        {
            Console.Write("Wpisz zadanie do wykonania: ");
            wpisane= Console.ReadLine();
            if (wpisane != "koniec")
            {
                File.AppendAllText("lista_zadan.txt", wpisane+Environment.NewLine);
            }
        } while (wpisane != "koniec");

        if (File.Exists("lista_zadan.txt"))
        {
            string[] zadania = File.ReadAllLines("lista_zadan.txt");
            Console.WriteLine("Liczba zadań: " + zadania.Length);
            foreach(string zadanie in zadania)
            {
                Console.WriteLine(zadanie);
            }
        }
    }
}