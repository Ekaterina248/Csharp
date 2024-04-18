/*
напишие программу которая будет принимать на вход два числа и проверять является одно число кратно другому
Если второе число не кратно первому, программа выводит остаток от делнеия

*/

Console.WriteLine("Введите 2 числа:");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
//Console.Write("первое число: " + number1+"; второе число: " + number2);
if (number1%number2==0)
{
    Console.Write("Второе число кратно первому ");
}
else
{
    Console.Write("остаток от деления первого числа на второе равен " + number1%number2);
}