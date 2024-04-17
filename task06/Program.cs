/*Напишите программу, которая на входе принимает число,
 и выдает является ли число четным
 */
Console.Write("ВВедите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number%2==1)
{
    Console.Write("Число " +number+" нечетное");
}
else
{
    Console.Write("Число " +number+" четное");
}