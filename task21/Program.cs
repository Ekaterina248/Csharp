/*
Дано натуральное трёхзначное число. Создайте массив, состоящий из
цифр этого числа. Младший разряд числа должен располагаться на 0-
м индексе массива, старший – на 2-м.
Пример
456 => [6 5 4]
781 => [1 8 7]

*/

Console.WriteLine(" Введите трехзначное число:  ");
int number = Convert.ToInt32(Console.ReadLine());
int []array=new int [3];
Console.Write("массив наоборот:[");
for (int i=0; i<2; i=i+1)
{
    array[i]=number%10;
    number = number/10;
    Console.Write($"{array[i]}, ");
}
Console.Write(number+"]");

