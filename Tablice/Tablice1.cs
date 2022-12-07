// tablice - zmienna (kolekcja) do trzymania wielu zmiennych

/*
int a = 3;
int b = 5;
int c = 6;
int d = 7;

int e;

int[] T = new int[5];
T[0] = 3;
T[1] = 5;
T[2] = 6;
T[3] = 7;
T[4] = 8;

Console.WriteLine(T[3] + " " + T[2]);

for (int i = 0; i < T.Length; i++)
{
    Console.WriteLine(T[i]);
}
*/
/*
int[] K = new int[] { 2, 3, 5, 8, 13, 21, 34, 55 };
for (int i = 0; i < K.Length; i++)
{
    Console.Write($"{K[i]} ");
    //Console.Write(K[i] + " ");
}*/

// Znajdź maks wartość w tablicy [4,5,8,9,7,6]
/*
int[] L = new int[] { 4, 5, 8, 9, 7, 6 };
int maks = -1000;

for (int i = 0; i < L.Length; i++)
{
    if (L[i] > maks)
    {
        maks = L[i];
    }
}
Console.WriteLine(maks);*/

// Znajdź mini wartość w tablicy [6,2,1,4,9,5]

int min = int.MaxValue;
int[] L = new int[] { 6, 2, 1, 4, 9, 5 };

for (int i = 0; i < L.Length; i++)
{
    if (L[i] < min)
    {
        min = L[i];
    }
}
Console.WriteLine(L[i]);
