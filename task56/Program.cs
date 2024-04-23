/*
Задайте значения M и N. Напишите программу,
которая выведет все натуральные числа в промежутке от M до N. 
Использовать рекурсию, не использовать циклы.

M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8"
*/
System.Console.WriteLine("задайте границы отрезка: ");
int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = Convert.ToInt32(Console.ReadLine());

void IntegerOtrezok(int m, int n)
{
    if (m == n + 1)
    {
        return;
    }
    System.Console.Write($"{m} ");
    IntegerOtrezok(m + 1, n);
}
System.Console.Write("Числа в отрезке: ");
IntegerOtrezok(n1, n2);
