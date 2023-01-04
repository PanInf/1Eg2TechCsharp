StreamReader sr = new StreamReader("ścieżka do pliku przyklad.txt");
int[] T = new int[500];
for (int i = 0; i < 500; i++)
{
    T[i] = int.Parse(sr.ReadLine());
}

/*while (!sr.EndOfStream)
{
    Console.Write(sr.ReadLine() + " ");
}*/

/*for (int i = 0; i < 500; i++)
{
    Console.Write(T[i] + "\t");
}*/


//Wersja 1

/*int[] P = new int[] { 1, 3, 9, 27, 81, 243, 729, 2197, 6561, 19683, 59049 };
int ilosc = 0;
for (int i = 0; i < 500; i++)
{
    for (int j = 0; j < 11; j++)
    {
        if (T[i] == P[j])
        {
            ilosc++;
            break;
        }
    }
}
Console.WriteLine(ilosc);*/

//Wersja 2

/*int ilosc = 0;
for (int i = 0; i < 500; i++)
{
    for (int j = 0; j < 11; j++)
    {
        if (T[i] == Math.Pow(3,j))
        {
            ilosc++;
            break;
        }
    }
}
Console.WriteLine(ilosc);*/

//Wersja 3

int x;
int ilosc = 0;
for (int i = 0; i < 500; i++)
{
    x = T[i];
    while (x > 1)
    {
        if (x % 3 == 0) x = x / 3;
        else break;
    }
    if (x == 1)
    {
        ilosc++;
    }
}
Console.WriteLine(ilosc);



