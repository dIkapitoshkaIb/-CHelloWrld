/* //Двумерные массивы с работой со строками
// string[,] table = new string[2,3];

//где, string-тип данных
//     ","-определение двумерного массива(2 размерности-строки и столбцы)
//     table- наименование массива
//     new string[количество строк, количество столбцов]

//Пример:

string[,] table = new string[2, 5];                 //задали "матрицу"
//Обращение по индексам
//инициализируем путём "String.Empty"
//table[0,0]    table[0,1]  table[0,2]  ....   table[0,4]
//table[0,2]    table[1,4]  table[1,3]  ....   table[1,1]
table[1,2] = "слово";

for(int rows=0; rows<2;rows++)                              // Написали цикл для строк
{
    for(int columns = 0; columns<5;columns++)               // "Вложили"(написали цикл в цикле)
                                                            // код для столбцов
    {
        Console.WriteLine($"-{table[rows, columns]}-");     //для проверки, что количество строк и столбцов верно
                                                            //нужно между фигурными скобками поставить знак "-"
    }
}
 */

/* //Двумерные массивы с работой с числами1.0

int[,] matrix = new int[3,4];

for(int i=0; i<3;i++)                                       // Написали цикл для строк
{
    for(int j = 0; j<4;j++)                                 // "Вложили"(написали цикл в цикле)
                                                            // код для столбцов
    {
        Console.WriteLine($"-{matrix[i, j]}-");             //для проверки, что количество строк и столбцов верно
                                                            //нужно между фигурными скобками поставить знак "-"
    }
}
 */


/* //Двумерные массивы с работой с числами2.0

int[,] matrix = new int[3,4];

for(int i=0; i<matrix.GetLength(0);i++)                     //Во время работы в массиве, можно использовать
                                                            //функцию "название массива"GetLength
{
    for(int j = 0; j<matrix.GetLength(1);j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
} */



//Двумерные массивы с работой с числами2.1
//Заполнение матрица рандомными числами.

int[,] matrix = new int[3, 4];

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);        // [1, 10)
        }
    }
}
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);