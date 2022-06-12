/* Задача 1.

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine(num1 + " большее число, " + num2 + " меньшее число.");
}
else if (num1 < num2)
{
    Console.WriteLine(num2 + " большее число, " + num1 + " меньшее число.");
}
else
{
    Console.WriteLine("Числа равны.");
}
*/

/* Задача 2.
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 >= max)
{
    max = num2;
}
if (num3 >= max)
{
    max = num3;
}
Console.WriteLine("Максимальное число: " + max);
*/

/* Задача 3.
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}
*/

/* Задача 4.
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Все четные числа от 1 до N: ");
int count = 2;
if(N >= 2)
{
    Console.Write(count);
    count = count + 2;
}
else 
{
    Console.Write("таких чисел нет.");
}
while(count <= N)
{
    Console.Write(", " + count);
    count = count + 2;
}
*/