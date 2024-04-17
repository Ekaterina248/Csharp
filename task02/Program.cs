/*Напишите программу, которая на входе принимает 2 числа и выдет какое число больше,
 какое меньше
 */
 Console.Write("ВВедите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("ВВедите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1>number2)
{
    Console.Write("Первое число больше");
}
else if (number1==number2)
{
    Console.Write("Числа равны");
}
else
{
    Console.Write("Второе число больше");
}