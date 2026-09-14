using System;

public class Zadanie
{
    static int ObliczSume(int[] liczby)
    {
        /**********************
        nazwa funkcji: ObliczSume
        opis: oblicz sumę liczb w tablicy
        parametry: tablica liczb całkowitych (int[])
        zwracany typ: liczba całkowita (int) - zwraca sumę liczb
        autor: 1
        **********************/
        int suma = 0;
        for (int i = 0; i < liczby.Length; i++)
        {
            suma += liczby[i];
        }
        return suma;
    }
    static void Main()
    {
        int[] liczby = new int[] { 10, 20, 30, 40 };
        
        Console.WriteLine("Suma wszystkich liczb to "+ObliczSume(liczby));
    }
} 
