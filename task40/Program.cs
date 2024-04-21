/* Лекция5. Рекурсия*/

void OpenMatreshka(int size)
{
    System.Console.WriteLine($"Открой матрешку размером {size} ...");
    if (size == 1)
    {
        System.Console.WriteLine("открыта самая маленькая матрешка");
        return;
    }

    OpenMatreshka(size - 1);
}

OpenMatreshka(5);