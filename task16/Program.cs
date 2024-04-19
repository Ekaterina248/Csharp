/*Напишите программу, которая принимает на вход координаты точки (X и Y),
 причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, 
в которой находится эта точка.
*/

Console.WriteLine("Введите координаты точки (x;y):");
Console.Write("x = ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("y = ");
int y = Convert.ToInt32(Console.ReadLine());
if (x>0 && y>0)
{
    Console.Write("точка лежит в первой координатной четверти ");
}
else if (x<0 && y>0)
{
    Console.Write("точка лежит во второй координатной четверти ");
}
else if (x<0 && y<0)
{
    Console.Write("точка лежит в третьей координатной четверти ");
}
else if (x>0 && y<0)
{
    Console.Write("точка лежит в четвертой координатной четверти ");
}
else 
{
    Console.Write("точка лежит на оси ");
}