/*
task 44. Задача1. Семинар 6. 
Задайте массив символов (тип char []). Создайте строку из
символов этого массива. 

*/

char[] charArr = {'a','b','c','d'};
//string str=new string (charArr);
string str="";
for (int i = 0; i <charArr.Length; i++)
{
    str=str+charArr[i];
}


System.Console.WriteLine(str);
