//Цикл "FOR"


/* string Method4(int count, string text)
{
    string result = String.Empty;
    for(int i = 0; i<count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(5, "qwerty ");
Console.WriteLine(res); */




// Цикл "FOR" в цикле

// Задача на составление таблицы умножения.

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");          // Пример интерполяции сроки
    }
    Console.WriteLine();                                    // Требуется для отступа на строку после выполнения цикла в цикле
}