Console.Write("Podaj liczbę wierszy: ");
int liczbaWierszy=int.Parse(Console.ReadLine());
int[,] liczby = new int[liczbaWierszy, 6];

Console.WriteLine("Uzypełnij tabelę liczbami");

for(int i = 0; i < liczby.GetLength(0); i++)
{
    for(int j = 0;j<liczby.GetLength(1); j++)
    {
        Console.Write("Wiersz " + (i+1) + ", kolumna " + (j+1) + ": ");
        liczby[i,j] = int.Parse(Console.ReadLine());
    }
}

string a = "_";
for(int i = 0; i < liczby.GetLength(0); i++)
{
    for(int k = 0; k < liczby.GetLength(1) * 2 + 1; k++)
    {
        Console.Write("--");
    }
    Console.WriteLine("");
    for(int j = 0; j < liczby.GetLength(1); j++)
    {
        Console.Write("|" + liczby[i,j]+ "|");
    }
    Console.WriteLine("");
}