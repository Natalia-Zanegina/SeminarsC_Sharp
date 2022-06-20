// Задача 1.
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*
int NumToPow(int num, int power)
{
    int result = 1;
    for (int i = 0; i < power; i++)
    {
        result *= num;
    }
    return result;
}
Console.Write("Введите число A: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int num2 = Convert.ToInt32(Console.ReadLine());

while(num2 <= 0)
    {
        Console.Write("В данной программе показатель степени должен быть натуральным числом. Введите другое число B: ");
        num2 = Convert.ToInt32(Console.ReadLine());
    }

Console.WriteLine($"{num1}^{num2} = {NumToPow(num1, num2)}");
*/

// Задача 2.
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 3, 44, 3 -> [1, 2, 5, 7, 19, 3, 44, 3]


void NewArr()
{
    int size = 8;
    int[] arr = new int[size];
    int length = arr.Length;
    for(int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
    Console.Write("[");
    for(int i = 0; i < length-1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[length-1]}]");
} 
NewArr();
