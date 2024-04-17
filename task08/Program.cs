/*Напишите программу, которая на входе принимает число N,
на выходе показывает все четные числа от 1 до N
 */
Console.Write("ВВедите положительное целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
for (int i=1; i<=number; i=i+1)
{
    Console.Write(i+" ");
}
