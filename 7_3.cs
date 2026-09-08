List<int> liczby = new List<int>();
int liczba;

Console.WriteLine("Podawaj liczby całkowite: ");
do
{
    liczba = int.Parse(Console.ReadLine());
    if (liczba != 0)
    {
        liczby.Add(liczba);
    }
} while (liczba != 0);

List<int> kopia = new List<int>();
for(int i = 0; i < liczby.Count; i++)
{
    if(liczby[i] >= 0)
    {
        kopia.Add(liczby[i]);
    }
}
liczby = kopia;

int suma = 0;
Console.WriteLine("Pozostałe liczby: ");
for(int i = 0;i < liczby.Count; i++)
{
    Console.WriteLine(liczby[i]);
    suma += liczby[i];
}
Console.WriteLine("Liczba elementów: "+liczby.Count);
Console.WriteLine("Suma: "+suma);