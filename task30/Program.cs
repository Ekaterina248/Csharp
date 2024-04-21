/*Напишите программу, которая перевернёт
одномерный массив (первый элемент станет
последним, второй – предпоследним и т.д.)
[1 3 5 6 7 8] => [8 7 6 5 3 1]*/
int[] FillArray (int size)
 {
  int[] arr = new int [size];
  for (int i=0; i<arr.Length; i=i+1)
 {
    arr[i] = new Random().Next(1,11);
 }
  return arr;
 }
 void PrintArray (int[] arr)
 {
    Console.Write("массив:[");
 for (int i=0; i<arr.Length-1; i=i+1)
 {
     Console.Write($"{arr[i]}, ");
 }
    Console.Write(arr[arr.Length-1]+"]");
    Console.WriteLine();
 }
int[] ArrNaoborot (int[] arr)//метод возвращает массив наоборот
{
    int size=arr.Length;
    int[] arr2=new int [size];
    for (int i=0; i<arr.Length; i=i+1)
    {
        size=size-1;
        arr2[size]=arr[i];
     }
    return arr2;
}

Console.Write("Введите длинну массива : ");
int s = Convert.ToInt32(Console.ReadLine());
int[] user_arr=FillArray(s);
PrintArray (user_arr);
Console.Write("Перевернутый ");
PrintArray (ArrNaoborot(user_arr));
