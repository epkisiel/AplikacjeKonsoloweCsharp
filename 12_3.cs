using System;

public class Zadanie
{
    abstract class Pracownik
    {
        public string imie;
        public Pracownik(string imie)
        {
            this.imie = imie;
        }
        public abstract double ObliczWynagrodzenie();
    }

    class PracownikEtatowy : Pracownik
    {
        double pensjaMiesieczna;
        public PracownikEtatowy(double pensjaMiesieczna, string imie) : base(imie)
        {
            this.pensjaMiesieczna = pensjaMiesieczna;
        }

        public override double ObliczWynagrodzenie()
        {
            return pensjaMiesieczna;
        }
    }
    class Zleceniobiorca : Pracownik
    {
        double stawkaGodzinowa;
        int liczbaGodzin;
        public Zleceniobiorca(double stawkaGodzinowa, int liczbaGodzin, string imie):base(imie)
        {
            this.stawkaGodzinowa = stawkaGodzinowa;
            this.liczbaGodzin = liczbaGodzin;
        }

        public override double ObliczWynagrodzenie()
        {
            return stawkaGodzinowa * liczbaGodzin;
        }
    }

    public static void Main(string[] args)
    {
        List<Pracownik> pracownicy = new List<Pracownik>
        {
            new PracownikEtatowy(4000,"Anna"),
            new Zleceniobiorca(30,27,"Tomek"),
            new PracownikEtatowy(5000,"Andrzej")
        };
        double suma = 0;
        
        foreach(Pracownik pracownik in pracownicy)
        {
            Console.WriteLine(pracownik.imie+", wynagrodzenie: "+pracownik.ObliczWynagrodzenie());
            suma += pracownik.ObliczWynagrodzenie();
        }
        Console.WriteLine("Suma wynagrodzeń: " + suma);
    }
}