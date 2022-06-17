/* Задача 1.
bool IsPalindrome(int num)
{
    if(num < 0) num *= (-1);

    if(num/10000 == num%10 && num / 1000 % 10 == (num % 100) / 10) return true;
    else return false;
}

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

while(Math.Abs(number) < 10000 || Math.Abs(number) >= 100000)
{
Console.WriteLine("Это число не пятизначное. Введите другое число: ");
number = Convert.ToInt32(Console.ReadLine());
}

if(IsPalindrome(number)) Console.WriteLine("Это палиндром.");
else Console.WriteLine("Это не палиндром.");
*/

/* Задача 2. 
double FindLength(double xA, double yA, double zA, double xB, double yB, double zB)
{
    double cathetus1 = Math.Sqrt(Math.Pow((xB-xA),2) + Math.Pow((zB-zA),2));
    return Math.Sqrt(Math.Pow(cathetus1,2) + Math.Pow((yB - yA),2));
}

Console.Write("Введите координату x первой точки: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y первой точки: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z первой точки: ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату x второй точки: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y второй точки: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z второй точки: ");
double zB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Длина отрезка: " + FindLength(xA, yA, zA, xB, yB, zB));
*/

/* Задача 3.
void Cube(int num)
{
    while(num < 1)
    {
        Console.WriteLine("Число должно быть больше или равно единице. Введите другое число: ");
        num = Convert.ToInt32(Console.ReadLine());
    } 
    int current = 1;
    while(current <= num)
    {
        Console.Write((Math.Pow(current,3)) + " ");
        current++;
    }
}

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

Cube(a);
*/