void FillArray(int[] collection)                //Метод заполнения массива без возращения
                                                //FillArray-наименование медота
                                                //int[] collection-аргумент
{
    int length = collection.Length;             // Получаем длину массива
    int index = 0;                              // Присваиваем переменной index
                                                //значение


    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); // Обращаемся к аргументу collection
                                                      // на позицию index и вносим новое
                                                      // рандомное значение от 1 до 10(согласно
                                                      // условию)
        index++;
    }
}


void PrintArray(int[] col)                      // Метод вывода значений массива без возвращения
                                                // PrintArray-название метода
                                                // int[] col-аргумент
{
    int count = col.Length;                     // Количество элементов
    int position = 0;                           // Текушая позиция
    while (position < count)
    {
        Console.WriteLine(col[position]);       // Выводим значение текущей позиции
        position++;
    }
}

int IndexOf(int[] collection, int find)         // Метод нахождения позиции в массиве с возвращением
                                                // значения
                                                // IndexOf-название метода
{
    int count = collection.Length;
    int index = 0;
    int position = -1;                          // Для опредения несуществующего
                                                // значения в массиве
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;                              // Для получения первой позиции
                                                // из нескольких одинковых значений
        }
        index++;
    }
    return position;                            // "return"-т.к. метод "int" возвращаемый
}

int[] array = new int[50];                      // Указвыаем количество элементов в
                                                // созданном массиве

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 123);                  // Определяем переменную для вывода значения "IndexOf"
Console.WriteLine(pos);