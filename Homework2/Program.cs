/* Задача 1.
int SecondDigit(int num)
{
    if(num >= 100 && num < 1000)
    {
    int result = num / 10 % 10;
    return result;
    }
    else return -1;
}

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(SecondDigit(num) == -1) Console.WriteLine("Число не является трехзначным.");
else Console.WriteLine(SecondDigit(num));
*/

/* Задача 2.
string ThirdDig(int num)
{
    int result = -1;
    if(num < 100) return ("Третьей цифры нет");
    else
    {
        while ((num / 100) >= 10)
        {
        num /= 10;
        }
        result = num % 10;
        return ("Третья цифра: " + result);
    }
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ThirdDig(num));
*/

/* Задача 3.
string HolidayOrNot(int day)
{
    if(day == 7) return ("Да, этот день выходной!");
    else if(day >= 1 && day < 7) return ("Нет, этот день не выходной...");
    else return ("В неделе нет такого дня.");
}

Console.Write("Введите номер дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(HolidayOrNot(num));
*/

