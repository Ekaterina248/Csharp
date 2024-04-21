/* task25

Задайте одномерный массив, заполненный случайными
числами. Определите количество четных чисел в этом
массиве.
Примеры
[1 3 4 19 3] => 2
[4 3 4 1 9 5 21 13] => 3

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
*/

//----------------------------------------------------------------------
/*task26

Задайте массив из N случайных целых чисел (N вводится с
клавиатуры).
Найдите количество чисел, которые оканчиваются на 1 и
делятся нацело на 7.
Пример
[1 5 11 21 81 4 0 91 2 3]
=> 2
*/
/*
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
Console.Write(CountKrat7End1(user_arr)); */
//-----------------------------------------------------------

/* 
task27

Заполните массив на N (вводится с консоли, не более 8)
случайных целых чисел от 0 до 9.
Сформируйте целое число, которое будет состоять из цифр из
массива. Старший разряд числа находится на 0-м индексе,
младший – на последнем. 
Пример
[1 3 2 4 2 3] => 132423
[2 3 1] => 231
 
int[] FillArray (int size)
 {
  int[] arr = new int [size];
  for (int i=0; i<arr.Length; i=i+1)
 {
    arr[i] = new Random().Next(0,10);
 }
  return arr;
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

 int GetNumber (int[] arr)
 {
    int result=0;
    for (int i=0; i<arr.Length; i=i+1)
    {
        result=result*10+arr[i];
    }
    return result;
 }

Console.Write("Введите длинну массива не более 8 цифр : ");
int s = Convert.ToInt32(Console.ReadLine());
int[] user_arr=FillArray(s);
PrintArray (user_arr);

Console.Write("Число = ");
Console.Write(GetNumber(user_arr));
*/
//------------------------------------------------------------------------

/* task28
Напишите программу, которая бесконечно
запрашивает целые числа с консоли. Программа
завершается при вводе символа ‘q’ или при вводе
числа, сумма цифр которого четная.
5 12 16 q [STOP]
3 45 342 15 [STOP]*/

/* int[] PreobrNumberInArr (int num)//метод преобразования числа в массив наоборот
{
    double sdouble = Math.Floor(Math.Log10(num) + 1);
    int s=Convert.ToInt32(sdouble);
    int[] arr=new int [s];
    //Console.Write("массив наоборот:[");
    for (int i=0; i<arr.Length; i=i+1)
   {
    arr[i]=num%10;
    num = num/10;
    
    }
    return arr;
} */
/* int SumCifrInCount (int num)// МОЙ метод суммирует цифры в числе
{
    double sdouble = Math.Floor(Math.Log10(num) + 1);//нашли кол-во цифр в числе
    int s=Convert.ToInt32(sdouble);//преобразовали кол-во цифр в числе в тип int
    int[] arr=new int [s];
    int sum=0;
    for (int i=0; i<arr.Length; i=i+1)
   {
    arr[i]=num%10;// записываем массив с конца числа
    num = num/10;
    sum = sum+arr[i];
    }
    return sum;
} */
int SumCifrInCount (int num)// метод ИЗ ЛЕКЦИИ суммирует цифры в числе
{
    int sum=0;
    while (num>0)
    {
      sum = sum+num%10;
      num=num/10;
    }
    
    return sum;
}

/* void PrintArray (int[] arr)
 {
    Console.Write("Массив:[");
 for (int i=0; i<arr.Length-1; i=i+1)
 {
     Console.Write($"{arr[i]}, ");
 }
    Console.Write(arr[arr.Length-1]+"]");
    Console.WriteLine();
 } */

Console.WriteLine("Введите целое число или нажмите q для выхода : ");
string string_number=Console.ReadLine();
int number=Convert.ToInt32(string_number);//!ПРОБЛЕМА не может q преобразовать в число
//Console.Write(SumCifrInCount(number));
//while (SumCifrInCount(number)%2==1 || string_number!="q")
while (SumCifrInCount(number)%2==1)
{     
     string_number=Console.ReadLine();
     number=Convert.ToInt32(string_number);
}
Console.Write("[STOP]");


