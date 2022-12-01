Console.WriteLine($"Найти точку пересечения двух прямых, заданных уравнением y = k1 * x + b1; y = k2 * x + b2.\nВведите значение b1:");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1:");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2:");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2:");
double k2 = Convert.ToInt32(Console.ReadLine());

double FindX(double k1, double b1, double k2, double b2)
{
    double x = (-b2 + b1) / (-k1 + k2);
    return x;
}
double x = Math.Round(FindX(k1, b1, k2, b2), 1, MidpointRounding.ToZero);
double FindY(double k2, double b2, double x)
{
    double y = k2 * x + b2;
    return y;
}
double y = FindY(k2, b2, x);
Console.WriteLine($"Точка пересечения двух прямых имеет координаты ({x},{y})");