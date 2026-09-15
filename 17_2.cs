using System;

public class Zadanie
{
    static int PobierzRokUrodzenia(string pesel)
    {
        string cyfryRoku = pesel[0].ToString()+pesel[1].ToString();
        string cyfryMiesiaca=pesel[2].ToString()+pesel[3].ToString();

        if (int.Parse(cyfryMiesiaca)>=1&&int.Parse(cyfryMiesiaca)<=12)
        {
            return 1900 + int.Parse(cyfryRoku);
        }
        else
        {
            return 2000 + int.Parse(cyfryRoku);
        }
    }

    static void Main(string[] args)
    {
        
    }
} 
