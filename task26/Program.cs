/*
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
int n1 = Convert.ToInt32(Console.ReadLine());10
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
*/
//--------------------------------------------------------------------------

/*

Задайте массив из N случайных целых чисел (N вводится с
клавиатуры).
Найдите количество чисел, которые оканчиваются на 1 и
делятся нацело на 7.
Пример
[1 5 11 21 81 4 0 91 2 3]
=> 2
*/

void FillArray (int[] arr)
 {
    Console.WriteLine("Введите элементы массива: ");
  for (int i=0; i<arr.Length; i=i+1)
 {
    arr[i] = Convert.ToInt32(Console.ReadLine());
 }
 }
 
void PrintArray (int[] arr)
 {
    Console.Write("Массив:[");
 for (int i=0; i<arr.Length-1; i=i+1)
 {
     Console.Write($"{arr[i]}, ");
 }
    Console.Write(arr[arr.Length-1]+"]");
    Console.WriteLine();
 }

 int CountKrat7End1 (int[] arr)
 {
    int result=0;
    for (int i=0; i<arr.Length; i=i+1)
    {
        if (arr[i]%7==0 && arr[i]%10==1 )
        {result++;}
    }
    return result;
 }

Console.Write("Введите длинну массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] user_arr = new int [size];
FillArray(user_arr);
PrintArray (user_arr);

Console.Write("количество чисел, которые оканчиваются на 1 и делятся нацело на 7 = ");
Console.Write(CountKrat7End1(user_arr));