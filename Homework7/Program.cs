int[,] CreateRandomTwoDimArray(int m, int n, int min, int max)
{
    int[,] newMatrix = new int[m,n];

    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            newMatrix[i,j] = new Random().Next(min, max + 1);
            Console.Write(newMatrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    return newMatrix;
}


// Задача 1.
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


/*
double[,] RandomTwoDimArrayDouble(int m, int n)
{
    double[,] newMatrix = new double[m,n];

    for(int i = 0; i < m; i++)
        for(int j = 0; j < n; j++)
            newMatrix[i,j] = Math.Round(new Random().Next(-10,11) + new Random().NextDouble(), 1);

    return newMatrix;
}

void ShowTwoDimArrayDouble(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            string element = Convert.ToString(array[i,j]);
            string space = string.Empty;
            for (int k = 0; k < 5-element.Length; k++)
                space += " ";
            Console.Write(space + array[i,j]);
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

ShowTwoDimArrayDouble(
   RandomTwoDimArrayDouble(m,n)
);
*/


// Задача 2.
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

/*
string IfExists (int[,] array, int row, int column)
{
    string result = string.Empty; 
    if(row <= array.GetLength(0) && column <= array.GetLength(1)) return result += array[row,column];
    else return "Такого числа в массиве нет";

} 

int[,] myArray = CreateRandomTwoDimArray(3,4,1,9);

Console.WriteLine("Введите номер строки: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер столбца: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Значение элемента с индексом [{m},{n}]: {IfExists(myArray, m, n)}");
*/


// Задача 3.
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

/*
string RowAverage(int[,] array)
{
    string result = "Среднее арифметическое каждого столбца: ";

    for (int i = 0; i < array.GetLength(1); i++)
    {
        double count = 0, sum = 0;
        double average = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j,i];
            count++;
        }
        average = Math.Round(sum / count, 1);
        result += (average + " ");  
    }
    return result;

}

int[,] myArray = CreateRandomTwoDimArray(3,4,1,9);
Console.WriteLine(RowAverage(myArray));
*/