/*
Задайте двумерный массив из целых чисел. Сформируйте новый
одномерный массив, состоящий из средних арифметических
значений по строкам двумерного массива. 

Пример
2 3 4 3
4 3 4 1 => [3 3 5]
2 9 5 4

*/

int[,] Fill2Array(int row, int colum) // рендом 2-массива
{
    int[,] arr = new int[row, colum];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);

        }
    }
    return arr;
}

void Print2Array(int[,] arr)// печать 2-массива
{ for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j]+"\t");

        }
        System.Console.WriteLine();
    }

}

void Print1Array (int[] arr)// печать 1-массива
 {
    Console.Write("Массив:[");
 for (int i=0; i<arr.Length-1; i=i+1)
 {
     Console.Write($"{arr[i]}, ");
 }
    Console.Write(arr[arr.Length-1]+"]");
    Console.WriteLine();
 }

int[] ArraySrArifm(int[,] arr)
{
    int[] arr_srarifm = new int[arr.GetLength(0)];
for (int i = 0; i < arr.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        { sum = sum + arr[i, j]; }
    }
    int srarifm = sum / arr.GetLength(1);
    arr_srarifm[i]=srarifm;
    }
return arr_srarifm;
}

System.Console.WriteLine("Введите кол-во строк и столбцов в 2-м массиве:");   
int r = Convert.ToInt32(Console.ReadLine()); 
int c = Convert.ToInt32(Console.ReadLine()); 
int[,] matrix=Fill2Array(r,c);
Print2Array(matrix);
System.Console.Write("массив из средних арифметических значений по строкам = ");
int[] matrix_srarifm=ArraySrArifm(matrix);
Print1Array(matrix_srarifm);