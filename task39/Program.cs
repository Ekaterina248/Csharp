/*
Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с
наименьшей суммой элементов
4 3 1 => Строка с индексом 0
2 6 9
4 6 2 
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

int StrSumMin(int[,] arr)
{
    int index_r=0;
    int sum=0;
    
    for (int j = 0; j <arr.GetLength(1); j++)//найдем сумму 0-й строки
    { sum=sum+arr[0,j]; }
    int min=sum;                                //запишем сумму 0-й строки в min
    
    for (int i = 1; i <arr.GetLength(0); i++)
    {
        sum=0;
        for (int j = 0; j <arr.GetLength(1); j++)
        { sum=sum+arr[i,j]; }
        if (sum<min)
        {min=sum;
         index_r=i;
        }
    }
    return index_r;
}

System.Console.Write("строка с наименьшей суммой элементов №: ");
System.Console.WriteLine(StrSumMin(matrix));