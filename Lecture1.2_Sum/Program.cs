//Сложение двух чисел.

int numberA = 3;
int numberB = 4;
int result = numberA + numberB;
Console.WriteLine(result);

//Сложение двух рандомных чисел.

int numberA = new Random().Next(1, 10); // 1 2 3 4 ... 9
int numberB = new Random().Next(1, 10);
int result = numberA + numberB;
Console.WriteLine(result);

//Сложение двух рандомных чисел c выводом чисел.

int numberA = new Random().Next(1, 10); // 1 2 3 4 ... 9
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine(result);
