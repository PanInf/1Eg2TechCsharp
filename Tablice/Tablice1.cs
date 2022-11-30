/*
Wygeneruj tablicę n losowych liczb:
Random r = new Random()
r.Next(pocz, kon)

n = 10 w przedziale [1,20]

1. Znajdź największą liczbę w tablicy
2. Znajdź najmniejszą liczbę w tablicy
3. Podaj ile razy występuje najwieksza liczba w tablicy
4. Podaj ile razy występuje najmniejsza liczba w tablicy
5. Podaj rozpiętość tablicy (różnica max - min)
6. Podaj sumę liczb w tablicy
7. Podaj średnią wartość liczb w tablicy
8. Których liczb jest więcej w tablicy: parzystych czy nieparzystych?
9. Ile w tablicy jest liczb pierwszych?
10. Podaj v-ce max i v-ce min liczb tablicy
*/

using System.Runtime.InteropServices;

int n = 10;
int pocz = 1;
int kon = 20;
int[] T = new int[n];
Random r = new Random();
for (int i = 0; i < n; i++) T[i] = r.Next(pocz, kon);

/*for (int i = 0; i < n; i++)
{
    Console.Write(T[i] + " ");
}*/

// 1. Znajdź największą liczbę w tablicy
/*int maksik = pocz;
for (int i = 0; i < n; i++)
{
	if (T[i] > maksik)
	{
		maksik = T[i];
	}
}
Console.WriteLine(maksik);*/

// 2. Znajdź najmniejszą liczbę w tablicy
/*int minik = kon;
for (int i = 0; i < n; i++)
{
    if (T[i] < minik)
    {
        minik = T[i];
    }
}
Console.WriteLine(minik);*/

// 8. Których liczb jest więcej w tablicy: parzystych czy nieparzystych?

/*int ilosc_parz = 0;
for (int i = 0; i < n; i++)
{
	if (T[i] % 2 == 0)
	{
		ilosc_parz = ilosc_parz + 1;
	}
}*/

// 10. Podaj v-ce max i v-ce min liczb tablicy

int maksik = pocz;
for (int i = 0; i < n; i++)
{
    if (T[i] > maksik)
    {
        maksik = T[i];
    }
}

int vce_maksik = pocz;
for (int i = 0; i < n; i++)
{
    if (T[i] > vce_maksik && T[i] < maksik)
    {
        vce_maksik = T[i];
    }
}

