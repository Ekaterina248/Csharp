/*Считать строку с консоли, содержащую латинские буквы.
Вывести на экран гласные буквы этой строки.
Указание
Использовать рекурсию. Не использовать цикл.

*/

void PrintGlas(string s, string s2, int i)
{

if (i==s.Length)
{
    return;
}
else
{
    for (int j=0; j<s2.Length;j=j+1)
    {
        if (s[i]==s2[j])
        {
        System.Console.Write($"{s[i]} ");
        }
    }
    PrintGlas(s,s2,i+1);
}
}

string st=Console.ReadLine();
string glass = "aeyuio";
PrintGlas(st,glass,0);