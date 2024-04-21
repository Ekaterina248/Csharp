/*
Задайте двумерный массив. Напишите
программу, которая поменяет местами первую и
последнюю строку массива.
4 3 1 => 4 6 2
2 6 9    2 6 9
4 6 2    4 3 1
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
{
    System.Console.WriteLine("матрица:");
     for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j]+"\t");

        }
        System.Console.WriteLine();
    }

}

System.Console.WriteLine("Введите кол-во строк и столбцов в 2-м массиве:");   
int r = Convert.ToInt32(Console.ReadLine()); 
int c = Convert.ToInt32(Console.ReadLine()); 
int[,] matrix=Fill2Array(r,c);
Print2Array(matrix);

int[,] ZamenaStrok(int[,] arr)
{
  int[] temp=new int[arr.GetLength(1)];
  for (int i = 0; i <arr.GetLength(0); i++)
  {
   for (int j = 0; j< arr.GetLength(1); j++)
   {
    if (i==0)
    { 
      temp[j]=arr[i,j];
      arr[i,j]=arr[arr.GetLength(0)-1,j];
      //arr[0,j]=arr[arr.GetLength(1),j];
    }
   }
  }  
  for (int j = 0; j < temp.Length; j++)
  {
    arr[arr.GetLength(0)-1,j]=temp[j];
  }
  return arr;
}

int[,] matrix2=new int[matrix.GetLength(0),matrix.GetLength(1)];
matrix2=ZamenaStrok(matrix);
System.Console.Write("Новая ");
Print2Array(matrix2);
