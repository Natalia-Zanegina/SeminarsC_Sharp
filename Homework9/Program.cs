// Задача 1. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

/*
int SumOfNaturalElements(int m, int n)
{
    if(m < 0) m = 0;
    if(n < 0) n = 0;
    if(m < n)
    {
        if(m < n) return m + SumOfNaturalElements(m + 1, n);
        else return n;
    }
    else
    {
        if(n < m) return n + SumOfNaturalElements(m, n + 1);
        else return m; 
    }
}

Console.WriteLine("Input first integer number: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second integer number: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The sum of natural elements in the interval from {m} to {n} is equal to {SumOfNaturalElements(m,n)}");
*/

// Задача 2. Напишите программу, которая будет принимать на вход число и возвращать кол-во его цифр.
// 453 -> 3
// 45 -> 2
/*
int CountOfDigits(int num)
{
    if(Math.Abs(num) > 9)
        return 1 + CountOfDigits(num /= 10);
    else return 1;
}

Console.WriteLine("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = CountOfDigits(num);
if (result == 1)
    Console.WriteLine($"There is {result} digit in the number {num}");
else Console.WriteLine($"There are {result} digits in the number {num}");
*/