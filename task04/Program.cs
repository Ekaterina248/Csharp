/*Напишите программу, которая на входе принимает 3 числа и выдает большее из этих чисел*/


Console.Write("ВВедите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("ВВедите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("ВВедите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max=number1;
if (number2>max)
{
  max=number2;
}
if (number3>max)
{
    max=number3;
}
Console.Write("Максимальное число = "+max);