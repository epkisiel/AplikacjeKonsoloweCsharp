using System;

public class Zadanie
{
    public class KontoBankowe
    {
        public double saldo { get; private set; }

        public KontoBankowe(double saldo)
        {
            this.saldo = saldo;
        }
        public KontoBankowe()
        {
            saldo = 0;
        }

        public void Wplac(double kwota)
        {
            if (kwota > 0)
            {
                saldo += kwota;
            }
        }
        public void Wyplac(double kwota)
        {
            if (kwota > 0 && kwota <= saldo)
            {
                saldo-=kwota;
            }
        }
        public void PokazSaldo()
        {
            Console.WriteLine("Saldo: " + saldo);
        }
    }
    public static void Main(string[] args)
    {
        var konto=new KontoBankowe();

        konto.PokazSaldo();
        konto.Wplac(10);
        konto.Wplac(-100);
        konto.Wyplac(3);
        konto.Wyplac(10);
        konto.PokazSaldo();
    }
}