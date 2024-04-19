/*
напишие программу которая будет принимать на вход число и определять 
кратно ли оно одновременно 7 и 23

*/

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number%7==0 && number%23==0)
{
    Console.Write("кратно ");
}
else
{
    Console.Write("не кратно");
}
