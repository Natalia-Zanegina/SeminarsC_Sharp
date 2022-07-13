string[] CreateStringArray(int size)
{
    string[] words = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} word: ");
        words[i] = Console.ReadLine();
    }

    return words;
}

void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i] + " ");
            Console.WriteLine();
    }
}
// Задача 1. Задайте массив строк. Напишите программу, считает кол-во слов в массиве, 
// начинающихся на гласную букву.
// Пример: { "qwe", "wer", "ert", "rty", "tyu"} -> 1

int StartingWithVowelCount(string[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        char l = array[i].ToLower()[0];
        if(l == 'a' || l == 'e' || l == 'i' || l == 'o' || l == 'u' || l == 'y') count++;
    }
    return count;
}

Console.Write("Input number of words: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] words = CreateStringArray(size);

Console.WriteLine($"{StartingWithVowelCount(words)} words are starting with a vowel letter in the array.");



// Задача 2. Задайте массив строк. Напишите программу, которая генерирует новый массив, 
// объединяя элементы исходного массива попарно.
// Пример: { "qwe", "wer", "ert", "rty", "tyu", "yui"} -> { "qwewer", "ertrty", "tyuyui"}
/*
string[] PairMerging(string[] array)
{
    int size = array.Length/2;
    if(array.Length % 2 != 0) size += 1;
    string[] result = new string[size];

    int j = 0;
    for(int i = 0; i < array.Length/2; i++, j+=2)
    {
        result[i] = array[j] + array[j + 1]; 
    } 

    if(array.Length % 2 != 0) 
        result[size-1] = array[array.Length-1];

    return result;
}

Console.Write("Input number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] words = CreateStringArray(size);

ShowArray(PairMerging(words));
*/