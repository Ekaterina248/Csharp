/*task 46. Задача3. Семинар 6
Считать строку с консоли, состоящую из латинских
букв в нижнем регистре. Выяснить, сколько среди
введённых букв гласных.

*/
//Console.WriteLine("введите строку состоящую из латинских букв в нижнем регистре: ");
//string st = (Console.ReadLine());
    string st="аоия777ккeky";
    string glasny="eyuioaуеыаоэяию";
    int sumglas=0;

    for (int i = 0; i < st.Length; i++)
    {
    for (int j=0; j<glasny.Length; j++)
    {
      if (st[i]==glasny[j])
      {
        sumglas=sumglas+1;
      }
    }
    }
    
    Console.WriteLine($"кол-во гласных букв в строке'{st}' равно {sumglas}");
    