// Группы методов
// Вид 1 Ничего не принимает, ничего не возвращает
void Method1()
{Console.Write("Автор...");}
Method1();

//Вид 2 Что то принимает, но ничего не возвращает
void Method2(string msg)
{Console.WriteLine(msg);}
Method2("Текстовое сообщение...");

void Method21(string msg, int count)
{int i=0;
while (i<count)
    {Console.WriteLine(msg);
    i++;
    }
}
Method21(msg: "Текст", 4);
Method21(count: 4, msg: "новый текст");

//Вид 3 Ничего не принимает,но что то возвращает
int Method3()
{return DateTime.Now.Year}
int year = Method3();
Console.WriteLine(year);

//Вид 4 Что то принимает и что то возвращает
string Method4(int count, string text)
{
    int i =0;
    string result =string.Empty;
    while(i<count)
    {
        result = result+text;
    i++;
    }
    return result;
    }
    string res = Method4(10, "Текст");
Console.WriteLine(res);