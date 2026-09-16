using System;

public class Zadanie
{
    static int LiczbaKobiet(string[] peseleTablica)
    {
        int ileKobiet = 0;
        for (int i = 0; i < peseleTablica.Length; i++)
        {
            if (OkreslPlec(peseleTablica[i]) == 'K')
            {
                ileKobiet++;
            }
        }

        return ileKobiet;
    }

    static char OkreslPlec(string pesel)

    {

        // Dziesiąta cyfra ma indeks 9 (liczymy pozycje od zera) 

        int cyfraPlci = (int)pesel[9];



        if (cyfraPlci % 2 == 0)

        {

            return 'K'; // cyfra parzysta oznacza kobietę 

        }

        else

        {

            return 'M'; // cyfra nieparzysta oznacza mężczyznę 

        }

    }

    static void Main(string[] args)
    {

    }
} 
