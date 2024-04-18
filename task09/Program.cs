/*напишите программу которая выводит случайное число из отрезка [10,99]
и показывает наибольшую цифру числа
*/

int number = new Random().Next(10,100);
Console.WriteLine(number);
int first=number%10;
int second=number/10;
if (first>second)
{
    Console.WriteLine(first);
}

else
{
    Console.WriteLine(second);
}
