/*Задайте одномерный массив из 10 целых чисел от 1 до 100. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,90].
*/
int[] array = new int [10];
for (int i=0; i<array.Length; i=i+1)
{
    array[i]=new Random().Next(1,101);
    Console.Write($"{array[i]}, ");
}
Console.WriteLine("");
int v = 0;
for (int i = 0; i < array.Length; i = i + 1)
{
    if (array[i]<=90 && array[i]>=10 )
    {
        v = v+1;
        Console.Write (array[i]+", ");
    }
}
Console.WriteLine("");
Console.Write (v);