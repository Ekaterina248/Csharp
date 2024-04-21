/* Cчитать с консоли строку, состоящую из цифр и латинских букв.
Сформировать новую строку, состоящую из букв исходной строки
{1 2 3 p a s s w 0 r d} -> {p a s s w t d}*/

string GetLetters (string s)
{
    string letters="";
    foreach (char e in s)
    {
        if (char.IsAsciiLetter(e)==true)//if (char.IsAsciiLetter(e))
        {
            letters=letters+e;
        }
    }
    return letters;
}
Console.Write("Введите строку: ");
string str=Console.ReadLine();
string result=GetLetters(str);
Console.Write("Новая строка из букв латинского алфавита: ");
Console.Write(result);