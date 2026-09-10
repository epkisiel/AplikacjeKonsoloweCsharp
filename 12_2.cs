using System;

public class Zadanie
{
    class Zwierze
    {
        string imie;

        public virtual void WydajDzwiek()
        {
            Console.WriteLine("Zwierzę wydaje dźwięk.");
        }
    }

    class Pies : Zwierze
    {
        public override void WydajDzwiek()
        {
            Console.WriteLine("Hau hau");
        }
    }
    class Kot : Zwierze
    {
        public override void WydajDzwiek()
        {
            Console.WriteLine("Miau");
        }
    }

    public static void Main(string[] args)
    {
        Zwierze pies = new Pies();
        Zwierze kot = new Kot();
        pies.WydajDzwiek();
        kot.WydajDzwiek();
    }
}