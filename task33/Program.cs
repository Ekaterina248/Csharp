/* пример из лекции по continue*/

for (int i = 0; i < 5; i++)
{
    Console.Write($"Итерация {i}:");
    if (i==3)
    {
        Console.WriteLine("3");
        continue;
    }
    Console.WriteLine("До этого момента не дошел цикл for при i=3, но продолжил свою работу");
}