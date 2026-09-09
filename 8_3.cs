Console.Write("Podaj liczbę zestawów: ");
int ileZestawow = int.Parse(Console.ReadLine());
int[,] zestawy = new int[ileZestawow, 6];
Random losowanie = new Random();
int[] ileRazy = new int[49];
Array.Fill(ileRazy, 0);

for (int i = 0; i < ileZestawow; i++)
{
    for (int j = 0; j < 6; j++)
    {
        zestawy[i, j] = losowanie.Next(1, 50);
        ileRazy[zestawy[i, j] - 1]++;
        Console.Write("|" + zestawy[i, j]);
    }
    Console.WriteLine("|");
}

int najczestszaLiczba = 1;

for (int i = 1; i < ileRazy.Length; i++)
{
    if (ileRazy[i] > ileRazy[najczestszaLiczba-1])
    {
        najczestszaLiczba = i;
    }
}

Console.WriteLine("Liczba, która została wylosowana najczęściej to " + najczestszaLiczba + ". Została wylosowana " + ileRazy[najczestszaLiczba - 1] + " razy.");