/*
Напишите программу, которая на вход
принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание,
что такого элемента нет

4 3 1 (1,2) => 9
2 6 9 

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

System.Console.WriteLine("Введите кол-во строк и столбцов в 2-м массиве:");   
int r = Convert.ToInt32(Console.ReadLine()); 
int c = Convert.ToInt32(Console.ReadLine()); 
int[,] matrix=Fill2Array(r,c);
Print2Array(matrix);

System.Console.Write("Введите номер строки нужного элемента:");
int num_r = Convert.ToInt32(Console.ReadLine()); 
System.Console.Write("Введите номер столбца нужного элемента:");
int num_с = Convert.ToInt32(Console.ReadLine()); 

if (num_r>matrix.GetLength(0)-1 || num_с > matrix.GetLength(1)-1)
{
    System.Console.Write("элемента с таким номером нет в массиве");
}
else
{
    System.Console.Write($"элемент массива = {matrix[num_r,num_с]}");
}