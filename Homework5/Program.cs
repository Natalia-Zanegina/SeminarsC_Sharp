/*
int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max+1);
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();

    return newArray;
}
*/
// Задача 1.
// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
/*
int CountOfEvenNumbers(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) count++;
    }
    return count;
}

int[] my_array = CreateRandomArray(4, 100, 999);
int a = CountOfEvenNumbers(my_array);
Console.WriteLine($"Количество четных чисел в массиве: {a}");
*/

// Задача 2.
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
/*
int SumOfNumbersOnOddPositions(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0) sum += array[i];
    }
    return sum;
}

int[] my_array = CreateRandomArray(4, -100, 100);
int a = SumOfNumbersOnOddPositions(my_array);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях, равна {a}");
*/

// Задача 3.
// Задайте массив вещественных(дробных, см. Random().NextDouble()) чисел. Найдите разницу 
// между максимальным и минимальным элементом массива.
// [3 7 22 2 78] -> 76

double[] DoubleArrayRandom(int size, int min, int max)
{
    double[] newArray = new double[size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = Math.Round(new Random().NextDouble() * (max - min) + min, 2);
        //второй вариант: newArray[i] = Math.Round(new Random().Next(min, max) + new Random().NextDouble(), 2);
        //но во втором варианте я не уверена, что в массив попадает нужный диапазон (граничные значения)
        Console.WriteLine(newArray[i] + " ");
    }
    return newArray;
}

double DifferenceMaxMin(double[] array)
{
    double min = array[0];
    double max = array[0];
    
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min) min = array[i];
        if(array[i] > max) max = array[i];
    }

    double result = Math.Round(max - min, 2);
    return result;
}

double[] my_arr = DoubleArrayRandom(3, 30, 50);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {DifferenceMaxMin(my_arr)}");
