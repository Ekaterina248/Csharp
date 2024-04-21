//* Лекция5. Рекурсия*/

void OpenMatreshka(int size)
{
   if (size == 1)
    {
     System.Console.WriteLine("открыта самая маленькая матрешка");
     return;
    }
   
   OpenMatreshka(size - 1);
   System.Console.WriteLine($"Открыта матрешка размером {size} ...");
  
}

OpenMatreshka(5);