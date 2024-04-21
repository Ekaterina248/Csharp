/*выдать на экран сообщение 
в случае наличия в массиве нечетного числа*/

Console.WriteLine("START");
int[] numbers = {2,4,6,4,8,10};
foreach (int n in numbers)
{
    if (n%2==1)
    {
        Console.WriteLine("нечетное число найдено");
        break;
    }
}
Console.WriteLine("STOP");
