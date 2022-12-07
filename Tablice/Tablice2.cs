// ROZGRZEWKA
// Stwórz tablicę 100 losowych liczb 2-cyfrowych
// podaj sumę liczb parzystych i ilość liczb nieparzystych

/*int[] T = new int[100];
Random r = new Random();

for (int i = 0; i < T.Length; i++)
{
    T[i] = r.Next(10, 100);
}

int suma_parz = 0;
int ilosc_nieparz = 0;
for (int i = 0; i < T.Length; i++)
{
    if (T[i] % 2 == 0) suma_parz += T[i];
    else ilosc_nieparz += 1;
}
Console.WriteLine(suma_parz + " " + ilosc_nieparz);*/

// TABLICE 2-WYMIAROWE
// inicjowanie tablicy

//int[][] T2D = new int[5][5] ---> MA TO SENS
// T[2][3][1]  => T[2,3,1]
/*int[,] T2D = new int[5, 5];

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(T2D[i,j] + "\t");  // T[i][j]
    }
    Console.WriteLine();
}*/

// Zadeklaruj macierz a'la sudoku

/*int[,] M = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

for (int i = 0; i <3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(M[i, j] + "\t"); 
    }
    Console.WriteLine();
}*/

// Stwórz losową macierz 4x4 zawerającą dowolne cyfry

/*int[,] M = new int[4, 4];
Random r = new Random();
for (int i = 0; i < 4; i++)
    for (int j = 0; j < 4; j++)
        M[i, j] = r.Next(0, 10);

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
        Console.Write(M[i,j] + "\t"); 
    Console.WriteLine();
}*/

// wymiary macierzy...

/*int[,] M = new int[3, 5];
Console.WriteLine(M.Length);
Console.WriteLine(M.GetLength(0));
Console.WriteLine(M.GetLength(1));*/

//wypełnić macierz 3x5 liczbami dwucyfrowymi korzystając z GetLength()

int[,] M = new int[3, 5];
Random r = new Random();
for (int i = 0; i < M.GetLength(0); i++)
    for (int j = 0; j < M.GetLength(1); j++)
        M[i, j] = r.Next(10, 100);

for (int i = 0; i < M.GetLength(0); i++)
{
    for (int j = 0; j < M.GetLength(1); j++)
        Console.Write(M[i, j] + "\t");
    Console.WriteLine();
}
