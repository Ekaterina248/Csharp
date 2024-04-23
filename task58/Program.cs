/*
Семинар7. 
Задача 3: Задайте произвольный массив. Выведете
его элементы, начиная с конца. Использовать
рекурсию, не использовать циклы.
[1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1

*/

void ArrNaoborot(int[] arr, int i=0)
{
 if (i==arr.Length)
 {
 return;
 }
 ArrNaoborot(arr,i+1);
 System.Console.Write($"{arr[i]} ");

}

int[] array={1,2,5,0,10,34};
System.Console.Write($"Элементы массива начиная с конца: ");
ArrNaoborot(array,0);