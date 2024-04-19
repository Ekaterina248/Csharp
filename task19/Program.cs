/*Задайте массив из 10 элементов, заполненный числами из
промежутка [-10, 10]. Замените отрицательные элементы на
положительные, а положительные на отрицательные
*/
/*int[] array = { -1, 2, -8, -4, -5, 19, 7,10,11,-15 };
for (int i = 0; i < array.Length; i = i + 1)
{
    array[i] =-array[i];
    Console.Write(array[i]+", ");
}
*/

int[] array = new int [10];
for (int i=0; i<array.Length; i=i+1)
{
    array[i]=new Random().Next(-10,11);
    Console.Write($"{array[i]}, ");
}
Console.WriteLine("");
for (int j = 0; j < array.Length; j = j + 1)
{
    array[j] =-array[j];
    Console.Write(array[j]+", ");
}