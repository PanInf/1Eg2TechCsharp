// Zad 1
/*
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    Console.Write(Math.Pow(i, 3) + 3 + " ");
}
*/

// Zad 2

/*
for (int i = 105; i < 1000; i = i + 15)
{
    Console.Write(i + " ");
}
*/

// Zad 3
/*
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    if (n % i == 0)
    {
        Console.Write(i + " ");
    }
}
*/

// Zad 4
/*
int suma = 0;
for (int i = 10; i < 100; i++)
{
    suma += i;
}
Console.WriteLine(suma);
*/

// Zad 5
/*
int x;
int n = int.Parse(Console.ReadLine());
int suma = n * (n + 1) / 2;

for (int i = 0; i < n-1; i++)
{
    x = int.Parse(Console.ReadLine());
    suma = suma - x;
}
Console.WriteLine(suma);
*/

// Zad 6
/*
int n = int.Parse(Console.ReadLine());
int a = 0;
int b = 1;
int temp;
Console.Write($"{a} {b} ");
for (int i = 0; i < n-1; i++)
{
    temp = a;
    a = b;
    b = temp + b;
    Console.Write(b + " ");
}
*/

