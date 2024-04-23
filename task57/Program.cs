/*
Напишите программу вычисления функции Аккермана с помощью рекурсии.
 Даны два неотрицательных числа m и n.

n = 2, m = 3 -> A(n,m) = 29
 */

int Akkerman(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0)
    {
        return Akkerman(n - 1, 1);
    }
    else
    {
        return Akkerman(n - 1, Akkerman(n, m - 1));
    }
}
int akN =2 ;
int akM = 5;

System.Console.WriteLine($"Функция Аккермана  A({akN},{akM})= {Akkerman(akN,akM)}");