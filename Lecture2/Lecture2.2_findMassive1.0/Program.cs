/*
 СНАЧАЛО БЫЛО ТАК
Тип данных[] Имя массива = {Значение1, Значение2, ...}
int[] array = { 2, 3, 23, 11, 4 }

int [] array = { 0, 0, 0, 0, 0}
int[] array = new int[5];
int[] array = new int[] { 0, 0, 0, 0, 0 }
int [] array = new int[5] { 1, 3, 2, 9, 6 }
*/


// пример нахождения через функцию

/* int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int a1 = 15, b1 = 21, c1 = 39,
    a2 = 12, b2 = 23, c2 = 33,
    a3 = 14, b3 = 23, c3 = 33;
int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(max1, max2, max3);
Console.WriteLine(max);

int max = Max(
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3));
Console.Write("max = ");
Console.WriteLine(max); */

// пример нахождения через функцию2.0




int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int[] array = { 51, 224, 23, 34, 45, 16, 17, 28, 19 }; // Задаём название массива
// Технически, можно описать обращение к нужному эл-ту массива через
// индекс ARRAY[индекс массива] = присвоенное значение.
//          Например: "array[0] = 12".
array[0] = 12;
Console.WriteLine(array[5]);

int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8]));
Console.Write("Result = ");
Console.WriteLine(result);