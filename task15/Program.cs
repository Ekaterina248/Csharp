/*
написать программу , которая на вход приимает два числа 
и определяет я вляется ли одно квадратом другого
*/
/*
напишие программу которая будет принимать на вход два числа и проверять является одно число кратно другому
Если второе число не кратно первому, программа выводит остаток от делнеия

*/

Console.WriteLine("Введите 2 числа:");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
//Console.Write("первое число: " + number1+"; второе число: " + number2);
if (number1 == Math.Pow(number2,2) || number2 == Math.Pow(number1,2))
{
    Console.Write("кратно");
}
else
{
    Console.Write("не кратно");
}