/*выдать на экран сообщение 
в случае наличия в массиве нечетного числа*/

Console.WriteLine("START");
int[] numbers = {2,4,6,7,8,10};
foreach (int n in numbers)
{
    if (n%2==1)
    {
        Console.WriteLine("нечетное число найдено");
        break;
    }
    else
     {
        Console.WriteLine($"элемент массива {n} - четное число");
     }
}
Console.WriteLine("STOP");
