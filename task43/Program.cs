/* task31. Работа со строками на Лекции

Cчитать с консоли строку, состоящую из цифр и латинских букв.
Сформировать новую строку, состоящую из букв исходной строки
{1 2 3 p a s s w 0 r d} -> {p a s s w t d}*/

/*string GetLetters (string s)
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
*/
int a=1;
int b=3;
Console.WriteLine($"переменная {b} большей переменной {a}");// c $ строка интерполированная
string st="Hellow World";
for (int i = 0; i< st.Length; i=i+1) //записать строку наоборот
{
    Console.Write(st[st.Length-1-i]);
}

string st1="";             //пустая строка
string st2= String.Empty; //пустая строка
Console.WriteLine(st2);
Console.WriteLine(st1);
string st3=new string('2',10); //10 раз выведено то, что в ковычках
Console.WriteLine(st3);

char[] new_char={'w','o','r','l','d'}; //задали массив букв типа char
string st4=new string(new_char);      //задали новую строку с помощью команды new string переводим массив в сроку
Console.WriteLine(st4);