/* Задайте массив. Напишите программу, которая определяет,
присутствует ли заданное число в массиве. Программа
должна выдать ответ: Да/Нет.
*/

/*int[] array={1,2,8,4,5,19};
Console.Write("Введите число для поиска: ");
int number = Convert.ToInt32(Console.ReadLine());
int i=0;

 while (i<array.Length)
{
  if (array[i]==number)
  {
    //Console.Write("Да");
    i=array.Length+1;
  }
  else
  {
    i=i+1;
  }
}
if (i>array.Length)
{Console.Write("Число есть в массиве");}
else 
{Console.Write("Числа нет в массиве");}
*/
int[] array = { 1, 2, 8, 4, 5, 19 };
Console.Write("Введите число для поиска: ");
int number = Convert.ToInt32(Console.ReadLine());
int v = 0;
for (int i = 1; i < array.Length; i = i + 1)
{
    if (array[i] == number)
    {
        v = number;
    }
}
if (v == number)
{ Console.Write("Число есть в массиве"); }
else
{ Console.Write("Числа нет в массиве"); }
