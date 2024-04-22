/*Урок 6. Массивы и строки.ДЗ_2
Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, 
в которой все заглавные буквы заменены на строчные

“aBcD1ef!-” => “abcd1ef!-” */

/* char ch='D';
System.Console.WriteLine(Char.IsLower(ch));//проверяет строчную 
System.Console.WriteLine(Char.IsUpper(ch));//проверяет заглавную */

string st="aBcD1ef!-";
string st2="";
char[] charArr=new char [st.Length];
for (int i = 0; i < st.Length; i++)
{
    charArr[i]=st[i];
    if (Char.IsUpper(charArr[i]))
    {
       charArr[i]=Char.ToLower(charArr[i]);
    }
    st2=st2+charArr[i];
    //System.Console.Write($"'{charArr[i]}', "); //печать массива
}
System.Console.Write(st2);
