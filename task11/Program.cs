/*
напишие программу которая выводит трехзначное число и удаляет вторую цифру этого числа
456->46
782->72

*/

int number = new Random().Next(100,1000);
Console.WriteLine(number);
int first=number/100;
int second=number%10;
Console.WriteLine(first*10+second);