/*task 46. Задача3. Семинар 6
Считать строку с консоли, состоящую из латинских
букв в нижнем регистре. Выяснить, сколько среди
введённых букв гласных.

*/
Console.WriteLine("введите строку состоящую из латинских букв в нижнем регистре: ");
//string st = (Console.ReadLine());
string st="hellow";
string glasny="eyuioa";
int sumglas=0;

for (int i = 0; i < st.Length; i++)
{
 for (int j=0; j<glasny.Length; j++)
 {
   if (st[i]==glasny[j]) ;
   strnum=strnum+1;
 }
}