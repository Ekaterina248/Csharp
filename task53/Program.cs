/*Семинар7. Рекурсии.Задача2_2-й способ решения
Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от 1 до N.
Указание
Использовать рекурсию. Не использовать цикл.

N=5 => 1 2 3 4 5
*/

void IntegersN(int n, int count = 1)
{
if (n < count)
{
    return;
}
else
{
    System.Console.Write($"{count} ");
    IntegersN(n, count + 1);
}
}

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
IntegersN(num);