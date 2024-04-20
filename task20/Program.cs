/* Найдите произведения пар чисел в одномерном массиве. Парой
считаем первый и последний элемент, второй и предпоследний и
т.д. Результат запишите в новый массив.
Пример
[1 3 2 4 2 3] => [3 6 8]
[2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)
*/
Console.Write(" задайте длинну массива: ");
int l = Convert.ToInt32(Console.ReadLine());
int[] array = new int [l];
for (int i=0; i<l; i=i+1)
{
    array[i]=new Random().Next(1,11);
    Console.Write($"{array[i]}, ");
}

Console.WriteLine("");
for (int i=0;i<l/2;i=i+1)
{
    //int x=array[i]*array[array.Length-1-i]
    Console.Write((array[i]*array[array.Length-1-i])+", ");
}