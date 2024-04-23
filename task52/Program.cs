/*Семинар7. Рекурсии
Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от 1 до N.
Указание
Использовать рекурсию. Не использовать цикл.

N=5 => 1 2 3 4 5
*/
void Number_1ToN(int num)
{
  if (num==0)
  {
    return ;
   }
   else 
   {
    Number_1ToN(num-1);
   }
   System.Console.Write($"{num} ");
}

Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
Number_1ToN(n);
