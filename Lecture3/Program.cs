//Методы, функции





// Вид 1 - ничего не принимают, ничего не возвращают.


/* void Method1()
{
    Console.WriteLine("автор...")
}
Method1(); */






// Вид 2 - что-то принимают, ничего не возвращают.


/* void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("сообщение");

// Пример:
void Method22(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method22("сообщение", 5); */





// Вид 3 - ничего не принимают, что-то возвращают.


/* int Method3()
{
    return;
} */


// Пример:
/* int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year); */






// Вид 4 - что-то принимают, что-то возвращают.


/* string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while(i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(5, "qwerty ");
Console.WriteLine(res); */