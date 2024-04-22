/*task 46. Задача3. Семинар 6
Считать строку с консоли, состоящую из латинских
букв в нижнем регистре. Выяснить, сколько среди
введённых букв гласных.

*/
Console.WriteLine("введите строку состоящую из латинских букв в нижнем регистре: ");
//string st = (Console.ReadLine());
string st="hellow";

char[] charArr=new char [st.Length];
int sumglas=0;
for (int i = 0; i < st.Length; i++)
{
    charArr[i]=st[i];
    /* if (charArr[i]==e);//как задать условие???
    {
        sumglas=sumglas+1;
    } */
    System.Console.Write($"'{charArr[i]}', "); 
}
System.Console.WriteLine();
System.Console.WriteLine(charArr[1].CompareTo('t'));
System.Console.WriteLine(charArr[1].CompareTo('h'));
System.Console.WriteLine(charArr[1].CompareTo('l'));
System.Console.WriteLine(charArr[1].CompareTo('r'));
System.Console.WriteLine();
System.Console.WriteLine($"сумма гласных = {sumglas}"); 
/*for (int i = 0; i < st.Length; i++)
{
    if (st.Contains('e');
}

System.Console.WriteLine(st.Contains('e'));*/