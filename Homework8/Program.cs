int[,] CreateRandomTwoDimArray(int m, int n, int min, int max)
{
    int[,] newMatrix = new int[m,n];

    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            newMatrix[i,j] = new Random().Next(min, max + 1);
        }
    }
    return newMatrix;
}

void ShowTwoDimArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}


// Задача 1.
// Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

/*
int[,] ArrangeElements(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if(array[i,k] < array[i,j])
                {
                    int temp = array[i,j];
                    array[i,j] = array[i,k];
                    array[i,k] = temp;
                }
            }
        }
    }
    return array;
}

int[,] myArray = CreateRandomTwoDimArray(3,4,1,9);
ShowTwoDimArray(myArray);

Console.WriteLine();

ShowTwoDimArray(
   ArrangeElements(myArray)
);
*/

// Задача 2.
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

/*
int SmallestSumRow(int[,] array)
{
    int minSum = 0;
    int minRow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];
        }

        if(i == 0) minSum = sum;
        else if(sum < minSum) 
        {
            minSum = sum;
            minRow = i;
        }
    }
    
    return minRow;
}

int[,] myArray = CreateRandomTwoDimArray(3,4,1,9);
ShowTwoDimArray(myArray);

Console.WriteLine();

Console.WriteLine($"Строка с наименьшей суммой элементов: {SmallestSumRow(myArray)}");
*/

// Задача 3.
// Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

/*
int[,] Spiral()
{
    int side = 4;
    int lateralElement = 1;
    int[,] result = new int[side,side];
    int num = 1;

    for (int k = 0; k < side - lateralElement * 2; k++)
    {
        for (int j = k; j < side - lateralElement - k; j++, num++)
            result[k,j] = num;
        
        for (int i = k; i < side - lateralElement - k; i++, num++)
            result[i,side - lateralElement - k] = num;

        for (int j = side - lateralElement - k; j >= k; j--, num++)
            result[side - lateralElement - k,j] = num;

        for (int i = side - lateralElement * 2 - k; i > k; i--, num++)
            result[i,k] = num;
    }

    return result;
}

int[,] myArray = Spiral();
ShowTwoDimArray(myArray);
*/