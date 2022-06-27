int[] CreateArray()
{
    Console.Write("Создадим массив. Введите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Введите {size} чисел: ");
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

// Задача 1.
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223 -> 3

/*
int GreaterThanZero (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if(array[i] > 0) count++;

    return count;
}

int[] myArray = CreateArray();

Console.WriteLine($"В массиве {GreaterThanZero(myArray)} чисел больше 0.");
*/

// Задача 2.
// Напишите программу, которая будет создавать копию заданного массива с помощью 
// поэлементного копирования.

/*
int[] CopyArray(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
        newArray[i] = array[i];

    return newArray;
}

int[] myArray = CreateArray();

int[] copiedArray = CopyArray(myArray);

Console.Write("Копия Вашего массива: ");
for (int i = 0; i < copiedArray.Length; i++)
    Console.Write($"{copiedArray[i]} ");
*/