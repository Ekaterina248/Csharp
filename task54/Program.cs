/*
Напишие программу, которая на вход принимает два числа А и В,
и возводит число A в целую степень В спомощью рекурсии

*/

int PowUser (int a, int b)
{
    if (b==1)
    {
        return a;
    }
    else
    {
        return a* PowUser(a,b-1);
    }
    

}

System.Console.WriteLine(PowUser(4,2));

