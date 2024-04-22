/*Урок 6. Массивы и строки.ДЗ_3
Задайте произвольную строку. Выясните,
является ли она палиндромом.
“aBcD1ef!-” => Нет
“шалаш” => Да
“55655” => Да
*/

string st="193464391";
System.Console.Write($"строка '{st}' - ");
string proverka="является полиндромом";
for (int i = 0; i < st.Length/2; i++)
{
    if (st[i]!=st[st.Length-1-i])
    {
      proverka="не является полиндромом";
    }
    break;
}
System.Console.WriteLine(proverka);

