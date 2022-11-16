// pętla while

// Przypomnienie fora i zamiana pętli na while

// Wypisanie cyfr od 1 do 9
/*
for (int i = 1; i < 10; i++)
{
    Console.Write(i + " ");
}
Console.WriteLine();*/

/*int j = 1;
while (j < 10)
{
    Console.Write(j + " ");
    ++j; // j++
}
Console.WriteLine();*/

/*
int k = 1;
do
{
    Console.Write(k + " ");
    k++;
} while (k < 10);*/

// pętla nieskończona
/*
int n = 0;
for (;;)
{
    n++;
    Console.Write("Ahoj");
    if (n == 100)
    {
        break;
    }
}*/
/*
int m = 0;
while (true)
{
    Console.Write("hey");
    if (m==100)
    {
        break;
    }
    m++;
}*/

// Napisz pętle while, wypisującą malejąco liczby 2-cyfrowe niepodzielne przez 3
/*
int k = 99;
while(k >= 10)
{
    if (k % 3 != 0)
    {
        Console.Write(k + " ");
    }
    k--;
}*/

// Karta Pracy 3 w while...

// Zad 1

/*int n = int.Parse(Console.ReadLine());

int i = 0;
while (i<n)
{
    Console.Write(i * i * i + 3 + " ");
    i++;
}*/

// for (int i = 0; i < n; i++) Console.WriteLine(i * i * i + 3);

// Zad 2

/*
int i = 105;
while (i < 1000)
{
    Console.Write(i + " ");
    i+=15;
}
*/

// Zad 3
/*
int n = int.Parse(Console.ReadLine());
int i = 1;
while (i <= n)
{
    if (n % i == 0)
    {
        Console.Write(i + " ");
    }
    i = i + 1;
}*/

// Zad 4
/*
int suma = 0;
int i = 99;
while (i > 9)
{
    suma = suma + i;
    i = i - 1;
}
Console.WriteLine(suma);*/

// Zad 5
/*
int n = int.Parse(Console.ReadLine());
int suma = n * (n + 1) / 2;
int i = 1, k;
while (i < n)
{
    k = int.Parse(Console.ReadLine());
    suma = suma - k;
    i = i + 1;
}
Console.WriteLine(suma);
*/

// Zad 6
/*
int n = int.Parse(Console.ReadLine());
int a = 0;
int b = 1;
int i = 0, temp;
while (i < n)
{
    temp = a;
    a = b;
    b = temp + b;
    Console.WriteLine(b);
    i = i + 1;
}*/

// Zadanie stricte na łajla
// Oblicz sumę cyfr zadanej liczby n

int n = int.Parse(Console.ReadLine());
int suma = 0;
while (n > 0)
{
    suma = suma + n % 10;
    n    = n / 10;
}
Console.WriteLine(suma);
