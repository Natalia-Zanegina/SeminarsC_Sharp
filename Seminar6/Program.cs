/*int[] ReverseArray(int[] array)
{
    int temp;
    int j = array.Length - 1;
    for(int i = 0; i < array.Length / 2; i++, j--)
    {
    temp = array[i];
    array[i] = array[j];
    array[j] = temp;
    }
return array;
}
int[] myArray = {2, 4, 6, 8, 10};
myArray = ReverseArray(myArray);
for(int i = 0; i < myArray.Length; i++)
{
    Console.Write(myArray[i] + " ");
}*/

// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
/*
bool Triangle(int a, int b, int c)
{
    if((a + b) > c && (c + b) > a && (a + c) > b) return true;
    return false;
}

Console.WriteLine("Enter a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter c: ");
int c = Convert.ToInt32(Console.ReadLine());

if(Triangle(a, b, c))Console.WriteLine("Такой треугольник существует");
else Console.WriteLine("Такого треугольника не существует");
*/
// Задача 2
/*
void Fibonacci(int n)
{
    int[] array = new int[n];
    array[0] = 0;
    array[1] = 1;
    Console.Write("0 1 ");
    for(int i = 2; i < n; i++)
    {
    array[i] = array[i - 1] + array[i - 2];
    Console.Write(array[i] + " ");
    }  
}

Console.WriteLine("Enter number: ");

int n = Convert.ToInt32(Console.ReadLine());
Fibonacci(n);
*/

// Задача 3.

string BinaryNumber(int num)
{
    string result = string.Empty;
    while(num > 0)
    {
        result = num % 2 + result;
        num /= 2;
    }
    return result;
}

Console.WriteLine(BinaryNumber(10));