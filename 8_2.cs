int[] wyniki = new int[20];
Random losowa= new Random();
int[] ileWystapien = {0,0,0,0,0,0};

for (int i=0;i<wyniki.Length;i++)
{
    wyniki[i] = losowa.Next(1, 7);
    ileWystapien[wyniki[i] - 1]++;
}

for(int j = 0; j < ileWystapien.Length; j++)
{
    Console.WriteLine("Ściankę " + (j + 1) + " wyrzucono " + ileWystapien[j] + " razy.");
}
