/*
int FindQuart(int x, int y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;

    return -1;
}

int result = FindQuart(2,4);

if(result == -1) Console.WriteLine("Данная точка расположена на осях");
else Console.WriteLine($"Точка находится в {result} четверти");
*/

/*Console.WriteLine("Введите номер четверти");
int num = Convert.ToInt32(Console.ReadLine());

void FindDiap(int quart)
{
    if(quart == 1) Console.WriteLine("Координаты x>0, y>0");
    if(quart == 2) Console.WriteLine("Координаты x<0, y>0");
    if(quart == 3) Console.WriteLine("Координаты x<0, y<0");
    if(quart == 4) Console.WriteLine("Координаты x>0, y<0");

} 

FindDiap(num);
*/
/*void Quad(int num)
{
    int current = 1;
    while(current <= num)
    {
        Console.Write((current * current) + " ");
        current++;
    }
}

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());


Quad(num);
*/
/*
double FindLength(double xA, double yA, double xB, double yB)
{
    return Math.Sqrt((xB - xA)*(xB - xA) + Math.Pow((yB - yA),2));
}

Console.Write("Введите координату x первой точки: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y первой точки: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату x второй точки: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y второй точки: ");
double yB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Длина отрезка: " + FindLength(xA, yA, xB, yB));
*/