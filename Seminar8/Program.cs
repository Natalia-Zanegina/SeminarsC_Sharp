int[,] CreateRandomTwoDimArray(int m, int n, int min, int max)
{
    int[,] newMatrix = new int[m,n];

    for(int i = 0; i< m; i++)
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

// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива

/*
int[,] ChangeLines(int[,] array, int strIndex1, int strIndex2)
{
    int temp;

    for(int j = 0; j < array.GetLength(1); j++)
    {
        temp = array[strIndex1, i];
        array[strIndex1,j] = array[strIndex2,j];
        array[strIndex2,j] = temp;
    }
}
*/

// Задача 1 
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

/*
int[,] ChangeRowsColumns(int[,] array)
{
    for (int i = 0; i < array.GetLength(0) - 1; i++)
    {
        for (int j = i+1; j < array.GetLength(1); j++)
        {
            int temp = array[i,j];
            array[i,j] = array[j,i];
            array[j,i] = temp;
        }
    }
    return array;
}

int m, n, min, max;


do
{
    Console.WriteLine("Введите данные. Число строк должно быть равно числу столбцов:");
    m = Convert.ToInt32(Console.ReadLine());
    n = Convert.ToInt32(Console.ReadLine());
    min = Convert.ToInt32(Console.ReadLine());
    max = Convert.ToInt32(Console.ReadLine());
}
while(m != n);

int[,] myArray = CreateRandomTwoDimArray(m, n, min, max);

ShowTwoDimArray(myArray);
Console.WriteLine();
myArray = ChangeRowsColumns(myArray);
ShowTwoDimArray(myArray);
*/



// Задача 2
// Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен 
// наименьший элемент.

int[,] DeleteRowColumn(int[,] array)
{
     
    int minRow = 0;
    int minColumn = 0;
    int min = array[minRow,minColumn];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           if(array[i,j] < min) 
           {
           min = array[i,j];
           minRow = i;
           minColumn = j;
           }
        }
    }

    for (int i = 0; i < array.GetLength(0); i++)
           array[i, minColumn] = 0;

    for (int j = 0; j < array.GetLength(1); j++)
           array[minRow, j] = 0;

    return array;
}

int[,] myArray = CreateRandomTwoDimArray(4,6,1,9);
ShowTwoDimArray(myArray);
Console.WriteLine();
myArray = DeleteRowColumn(myArray);
ShowTwoDimArray(myArray);
