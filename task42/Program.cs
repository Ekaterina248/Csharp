/*Лекция5. Рекурсии
Задача на нахождение факториала*/

int Fact(int n)
{
    if (n == 1 || n==0)
    {
        return 1;
    }

    return n * Fact(n - 1);
}

System.Console.WriteLine(Fact(4));
