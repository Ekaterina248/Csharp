/*Задайте одномерный массив, заполненный случайными
числами. Определите количество четных чисел в этом
массиве.
Примеры
[1 3 4 19 3] => 2
[4 3 4 1 9 5 21 13] => 3
*/
void FillArray (int start, int end, int[] arr)
 {
  for (int i=0; i<arr.Length; i=i+1)
 {
    arr[i]=new Random().Next(start,end);
 }
 }

void PrintArray (int[] arr)
 {
 for (int i=0; i<arr.Length; i=i+1)
 {
     Console.Write($"{arr[i]}, ");
 }
 }
int CountEven (int[] arr)
{
    int result=0;
    for (int i=0; i<arr.Length; i=i+1)
    {
        if (arr[i]%2==0)
        {result++;}
    }
    return result;
}

Console.WriteLine("Введите границы значений массива (границы Rendom)_2 числа: ");
int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длинну массива: ");
int lenght = Convert.ToInt32(Console.ReadLine());
int[] userarr = new int [lenght];
FillArray(n1,n2,userarr);
PrintArray (userarr);
Console.WriteLine();
int count=CountEven(userarr);
Console.Write("кол-во четных чисел в этом массиве = ");
Console.Write(count);
