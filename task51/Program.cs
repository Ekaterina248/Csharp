/*Семинар7. Рекурсии
Задача на нахождение факториала*/

/* int Fact(int n)
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

System.Console.WriteLine(Fact(5)); */
//_____________________________________________

/*Семинар7. Рекурсии
Напишите программу, которая будет принимать на вход число и
возвращать сумму его цифр.
Пример
123 => 6
63 => 9
*/
int SumNumber(int num)
{
  if (num==0)
  {
    return 0;
   }
   else 
   {
    return num%10+SumNumber(num/10);
   }
}

int number=991133;
System.Console.WriteLine(SumNumber(number));


