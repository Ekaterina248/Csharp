/*Лекция5. Рекурсии
Задача на нахождение факториала*/

int Fact(int n)
{
    if (n == 1 || n==0)
    {
        Console.WriteLine($"Stop: {n}");
        return 1;
    }
    System.Console.WriteLine(n);
    return n * Fact(n - 1);
    //Console.WriteLine(n); // не работает раскручивание!!!!???
}

System.Console.WriteLine(Fact(5));
