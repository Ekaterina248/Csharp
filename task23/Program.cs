/*Задайте массив на 10 целых чисел.
 Напишите программу, которая определяет количество чётных чисел в массиве.
 */

int[] array = new int [10];
for (int i=0; i<array.Length; i=i+1)
{
    array[i]=new Random().Next(1,11);
    Console.Write($"{array[i]}, ");
}
Console.WriteLine("");
int kolch=0;
for (int i = 0; i < array.Length; i = i + 1)
{
    if (array[i]%2==0)
    {
        kolch = kolch+1;
    }
}
Console.WriteLine("количество четных чисел в массиве = " + kolch);
