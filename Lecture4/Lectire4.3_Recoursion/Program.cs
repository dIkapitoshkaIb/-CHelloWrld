//Рекурсия-функция вызывающая саму себя.

//Пример:

//факториал:
//5!= 5*4*3*2*1
//    5*4!
//      4*3!
//        3*2!
//          2*1!

//Медот вычисления

/* int Factorial(int n)
{
    if(n==1) return 1;
    else return n*Factorial(n-1);
}
Console.WriteLine(Factorial(3));

~~~~

int Factorial (int n)
{
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
for (int i = 1; i <= 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}

~~~~

double Factorial (int n)
{
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
for (int i = 1; i <= 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
} */



// Задача на формулу чисел Фибоначчи(идеальное сечение)
// Условие
/* 
f(1) = 1
f(2) = 1
f(n) = f(n-1)+f(n-2)
 */

// Решение

/* double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
} */


// Задача "Как обойти директорию"?
/* Зайти в директорию
        Обойти все директории внутри */
            