// 1. Wygeneruj tablicę z 15 losowymi
// liczbami dwucyfrowymi nieparzystymi

/*Random r = new Random();
int[] T = new int[15];
int liczba;
for (int i = 0; i < T.Length; i++)
{
    liczba = r.Next(5, 50);
    T[i] = 2 * liczba + 1;
}
foreach (var e in T)
{
    Console.Write(e + " ");
}
Console.WriteLine();
int[] R = new int[15];
int x = 0;
while (x < 15)
{
    liczba = r.Next(10, 100);
    if (liczba % 2 == 1)
    {
        R[x] = liczba;
        x = x + 1;
    }
}
foreach (var e in R)
{
    Console.Write(e + " ");
}
Console.WriteLine();*/
// 2. Wygeneruj tablicę 20 dowolnych liczb dwucyfrowych
// i potem zaokrąglij każdą w górę do pełnej 10-tki

Random r = new Random();
int[] T = new int[20];
for (int i = 0; i < T.Length; i++)
{
    T[i] = r.Next(10, 100);
    Console.Write(T[i] + " ");
    if (T[i] % 10 != 0) T[i] = (T[i] / 10) * 10 + 10;
    Console.WriteLine(T[i]);
}


// 3. Wygeneruj listę 12 losowych liczb dwucyfrowych
// podzielnych przez 7




// 4. Wygeneruj losową tablicę 20 elementową składającą się
// z cyfr 1, 2 i 3. Znajdź najdłuższy podciąg
// identycznych cyfr. Jeśli jest więcej tak samo długich
// to wypisz ostatni z nich.

// 5. Dla chętnych - Algorytm Kadane'a

// 6. Listy 2-wymiarowe.
// Wygeneruj listę 10x10 losowych cyfr.
// Znajdz w ilu miejscach wystepują tacy sami sąsiedzi
// (lewo-prawo i góra-dół).

