/*task 44. Задача2. Семинар 6
На основе символов строки (тип string) сформировать массив
символов (тип char[]). Вывести массив на экран.*/

string st="Hello!";
char[] charArr=new char [st.Length];
for (int i = 0; i < st.Length; i++)
{
    charArr[i]=st[i];
    System.Console.Write($"'{charArr[i]}', "); 
}