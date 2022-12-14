// Zad 1

// int a = int.Parse(Console.ReadLine());
// int b = int.Parse(Console.ReadLine());
// int c = int.Parse(Console.ReadLine());

// // C. arytmetyczny
// if (b - a == c - b) Console.WriteLine("Jest arytmetyczny");
// if (b / a == c / b) Console.WriteLine("Jest geometryczny");

// Zad 2
// int suma = 0;
// for (int i = 100 ; i< 1000 ; i++)
// {
//     if (i % 8 == 0 && i % 16 != 0)
//     {
//         suma += i;
//     }
// }
// System.Console.WriteLine(suma);

// Zad 3

// int podzielnik = 0;
// for (int i=99 ; i>9 ; i--)
// {
//     if (i % 7 == 0)
//     {
//         podzielnik = i;
//         break;
//     }
// }

// int suma = 0;
// for (int j=100 ; j<1000 ; j++)
// {
//     if (j % podzielnik == 0)
//     {
//         suma += j;
//     }
// }
// System.Console.WriteLine(suma);

// Zad 4

// int ilosc = 0;
// int cd = 0;
// int cj = 0;
// for (int i=10 ; i<100 ; i++)
// {
//     cd = i / 10;
//     cj = i % 10;

//     if (cd >= 2 * cj)
//     {
//         ilosc += 1;
//     }
// }
// System.Console.WriteLine(ilosc);

// Zad 7

// int n = int.Parse(Console.ReadLine());
// int suma = 0;
// int skladnik = 0;
// for (int j=999 ; j>100 ; j++)
// {
//     if(j%37==0)
//     {
//         skladnik = j;
//         break;
//     }
// }
// for (int i=0 ; i<n ; i++)
// {
//     suma += (skladnik-37*i);
// }
// System.Console.WriteLine(suma);
// Zad 8

// int suma = 0;
// int n = int.Parse(Console.ReadLine());
// for (int i = 1 ; i <= n ; i++)
// {
//     suma = suma + ((3*i-1)*((int) Math.Pow(-1,i-1)));
// }
// System.Console.WriteLine(suma);

// Zad 10

// silnia 5! = 1 * 2 * 3 * 4 * 5
// int n = int.Parse(Console.ReadLine());
// int wynik = 1;
// int suma = 0;
// for (int i= 1 ; i <= n ; i++)
// {
//     wynik = 1;
//     for (int j=1 ; j <= i ;j++)
//     {
//         wynik = wynik * j;
//     }
//     suma = suma + wynik;
// }
// System.Console.WriteLine(suma);


// Zad 11

// double suma = 0;
// int n = int.Parse(Console.ReadLine());
// for (int i = 1 ; i <= n ; i++)
// {
//     suma = suma + (2*i-1)/Math.Pow(i,2);
// }
// System.Console.WriteLine(suma);


