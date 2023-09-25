//  Сортировка массива, путём выборки min/max

//  1. Найти позицию минимального элемента
//   в неотсортированной части массива
//  2. Произвести обмен этого значения со значением
//   первой неотсортированной позиции
//  3. Повторять пока есть неотсортированные элементы



//  Способ 1.

int[] arr = { 1, 5, 6, 4, 4, 3, 2, 6, 7 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)        // "array.Length-1"- если нало поиска позиции = i+1Б,
                                                    // то искусственно отнимаем единичку "i < array.Length-1"
    {
        int minPosition = i;                        // Создаём рабочую переменную для сохранения миниамльного 
                                                    // значения
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition])      // Если текущее значение меньше минимальной позиции,
                                                    // то присваиваем новое значение в минимальной позиции
            {
                minPosition = j;
            }
        }
        int temporary = array[i];                   // после выполнения кода нам нужно поменять
                                                    // минимальную позицию с той, которую нашли
        
        
        array[i] = array[minPosition];              // простой обмен переменных местами
        array[minPosition] = temporary;             //(СВАП)
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);