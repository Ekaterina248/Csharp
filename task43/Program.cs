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
Console.WriteLine($"st4: {st4}");

char[] char_arr= new char[st4.Length]; //задали новый массив равный длине стррки
for (int i=0; i< st4.Length; i=i+1)    //записали в новый массив st4 и распечатали
{
      char_arr[i]=st4[i];
      Console.Write($"{char_arr[i]} ");
}
Console.WriteLine();

    string s5="apple";
    string s6="a day";
    string s7="keeps";
    string s8="a doctor";
    string s9="away";
    string[] stArray={s5,s6,s7,s8,s9};//задаем массив из строк
    for (int i=0; i<stArray.Length; i=i+1) //печатаем массив из строк
    {
        Console.Write($"{stArray[i]} ");
    }
Console.WriteLine();

string fruits= "Яблоко, Банан, Груша";
string[] frutArr= fruits.Split(", "); // создание массива c разделением, указанным в скобках
for (int i=0; i<frutArr.Length; i=i+1) //печатаем массив из строк
    {
        Console.Write($"{frutArr[i]} ");
    }

Console.WriteLine();

string text = "хотим увидеть прикольную приколюху";
string[] textArr = text.Split(" "); // создание массива c разделением, указанным в скобках от строки text
PrintArray(textArr);

void PrintArray(string[] arr)
{
    Console.ForegroundColor = ConsoleColor.Green;//меняет цвет текста,который будет выводится после команды
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Thread.Sleep(10);                           //пауза
        System.Console.Write(arr[i]);
        if (i< arr.Length-1)
        System.Console.Write(", ");
    }
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.Write("]");
    Console.ResetColor();
}

System.Console.WriteLine();

string str="Старушка так и сделала: намела, наскребла горсти две муки,"
            +" замесила тесто на сметане, скатала колобок, изжарила его в масле и "
            +"положила на окно простынуть."
            +"Надоело колобку лежать — он и покатился с окна на лавку," 
            +"с лавки на пол — да к двери, прыг через порог, в сени, из"
            +"сеней на крыльцо, с крыльца на двор, а там и за ворота, дальше и дальше.";
System.Console.WriteLine(str);

System.Console.WriteLine();

string[] separate = { ", ", ". ", " — ", ": "," ", ".","," };
string[] stArr1 = str.Split(separate, StringSplitOptions.RemoveEmptyEntries);//принять группу разделителей
PrintArray(stArr1);
System.Console.WriteLine();
for (int i = 0; i < stArr1.Length; i++)
{
    System.Console.Write($"{stArr1[i]} ");
}

System.Console.WriteLine();

//----------------------------------------
/*Интовый массив в стринговый и наоборот*/

string strnum="1,2,3,4,5";
int[] num=new int[strnum.Length];
string[] charArr3=strnum.Split(",");
for (int i = 0; i <strnum.Length; i++)
{
    num[i]= Convert.ToInt32(charArr3[i]);
    System.Console.WriteLine(num[i]);
}
System.Console.WriteLine();