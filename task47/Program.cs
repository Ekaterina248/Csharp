/*Урок 6. Массивы и строки.ДЗ
Задайте двумерный массив символов (тип char [,]). 
Создать строку из символов этого массива.

a b c => “abcdef”
d e f 
*/

char[,] Fill2charArray(int row, int colum) // рендом 2-массива символов
{
    Random MyRandomValue = new Random();
    char[,] arr = new char[row, colum];
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
          for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j]=(char) MyRandomValue.Next('a', 'z'+1);
            
        }
    }
    return arr;
}

void Print2charArray(char[,] arr)// печать 2-массива из символов
{ for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j]+"\t");

        }
        System.Console.WriteLine();
    }

}


char[,] matrix=Fill2charArray(2,3);
Print2charArray(matrix);

string Arr2InString(char[,] arr) //массив в строку
{
    string st="";
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            st=st+arr[i,j];

        }
     }
    return st;
}

System.Console.Write("новая строка:");
System.Console.WriteLine(Arr2InString(matrix));