/*Урок 6. Массивы и строки.ДЗ_4*
Задача 4*(не обязательная): Задайте строку, состоящую
из слов, разделенных пробелами. Сформировать строку,
в которой слова расположены в обратном порядке. В
полученной строке слова должны быть также разделены
пробелами.

“Hello my world” => “world my Hello”

*/

string st="Hellow my world Ура! решена Задача";
string st_naoborot="";

string[] strArr= st. Split (" "); // создание массива c разделением, указанным в скобках
for (int i=0; i<strArr.Length; i=i+1) //печатаем массив из строк
{
 st_naoborot=st_naoborot+strArr[strArr.Length-1-i]+" ";
 //System.Console.WriteLine(strArr[i]);
} 
    

Console.WriteLine(st_naoborot);