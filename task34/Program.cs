/*
Задайте двумерный массив. Найдите элементы, у которых оба
индекса чётные, и замените эти элементы на их квадраты.
Пример
2 3 4 3
4 3 4 1 =>
2 9 5 4

4 3 4 3
4 3 4 1
2 9 25 4
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

int[,] ChetInArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i%2==0 && j%2==0)
            {arr[i,j]=arr[i,j]*arr[i,j];}
        }
    }
    return arr;
}

System.Console.WriteLine("Введите кол-во строк и столбцов в 2-м массиве:");   
int r = Convert.ToInt32(Console.ReadLine()); 
int c = Convert.ToInt32(Console.ReadLine()); 
int[,] matrix=Fill2Array(r,c);
Print2Array(matrix);
System.Console.WriteLine("массив новый");
Print2Array(ChetInArray(matrix));