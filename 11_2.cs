using System;

public class Zadanie
{
    public class Ksiazka
    {
        private string tytul;
        private string autor;
        private int liczbaStron;
        public string Tytul { get { return tytul; } set { tytul = value; } }
        public string Autor { get { return autor; } set { autor = value; } }
        public int LiczbaStron { get { return liczbaStron; } set { if (value > 0) { liczbaStron = value; } else { liczbaStron = 1; } } }

        public Ksiazka(string tytul, string autor, int liczbaStron)
        {
            Tytul= tytul;
            Autor= autor;
            LiczbaStron= liczbaStron;
        }

        public void Opisz()
        {
            Console.WriteLine($"\"{tytul}\" {autor}, liczba stron: {liczbaStron}");
        }
    }

    public static void Main(string[] args)
    {
        var ksiazka = new Ksiazka("Tytuł książki", "Autor Książki", 300);
        ksiazka.Opisz();
    }
}