/*Задайте массив из вещественных чисел с ненулевой дробной частью. 
Найдите разницу между максимальным и минимальным элементов массива.
*/

double[] array = {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01};
for (int i=0; i< array.Length; i=i+1)
{
        Console.Write($"{array[i]}; ");
}
Console.WriteLine("");
double max=array[0];
double min=array[0];
for (int i=0; i< array.Length; i=i+1)
{
    if (array[i]<min)
    {
        min=array[i];
    }
    else if (array[i]>max)
    {
        max=array[i];
    }
}
Console.WriteLine("минимальное= "+min+" ; максимальное= "+max);
Console.Write("разница минимального и максимального= "+(max-min));