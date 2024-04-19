/*Напишите программу, которая на вход принимает натуральное число N,
 а на выходе показывает его цифры через запятую.*/

Console.WriteLine("Введите натуральное число:");
int number = Convert.ToInt32(Console.ReadLine());
int celoe=number;
while (celoe>10)
{
    Console.Write(celoe%10+", ");
    celoe=celoe/10;

}
Console.Write(celoe+".");
