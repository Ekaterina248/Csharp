//* Лекция5. Рекурсия*/

void OpenMatreshka(int size)
{
   if (size == 1) //базовый случай, когда нужно выйти из функции
    {
     System.Console.WriteLine("открыта самая маленькая матрешка");
     return;
    }
   
   //System.Console.WriteLine($"Открыта матрешка размером {size} ..."); // напечатает от большего к меньшему, т.к. до вызова рекурсии
   OpenMatreshka(size - 1);
   System.Console.WriteLine($"Открыта матрешка размером {size} ...");//напечатает от меньшего к большему, т.к. после вызова рекурсии
  
}

OpenMatreshka(5);