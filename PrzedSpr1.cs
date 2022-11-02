// Zad 1 - Light Hard -  Napisz program, który obliczę sumę n pierwszych liczb fibonacciego
// 1 + 2 + 3 + 5 + 8 + ....

/*int n = int.Parse(Console.ReadLine());
int a = 0;
int b = 1;
int temp;
int suma = 0;
for (int i = 0; i < n; i++)
{
    temp = a;
    a = b;
    b = b + temp;
    suma = suma + b;
}
Console.WriteLine(suma);*/

// Zad 2 - Medium - Napisz program sumujący w początkowych liczb trzycyfrowych

// 1
/*int w = int.Parse(Console.ReadLine());
int suma = 0;
for (int i = 100; i < 100 + w; i++)
{
    suma = suma + i;
}
Console.WriteLine(suma);*/

//2
/*
int w = int.Parse(Console.ReadLine());
int suma = 0;
for (int i = 0; i < w; i++)
{
    suma = suma + 100 + i;
}
Console.WriteLine(suma);
*/

// Zad 3 - Hard - Sprawdź czy wpisana przez usera liczba jest doskonała
// 6 = 1 + 2 + 3
// 28 = 1 + 2 + 4 + 7 + 14
// 10 = 1 + 2 + 5 (nie jest doskonała)

/*
int n = int.Parse(Console.ReadLine());
int suma = 0;
for (int i = 1; i < n; i++)
{
    if (n % i == 0)
    {
        suma = suma + i;
    }
}
if (suma == n)
{
    Console.WriteLine("DOSKNAŁA");
}
else
{
    Console.WriteLine("NIE i SPADAJ");
}
*/
