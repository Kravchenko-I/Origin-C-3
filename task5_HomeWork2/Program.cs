//  Напишите программу, которая принимает 
// на вход координаты двух точек и находит расстояние 
// между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
Console.WriteLine("Введите координаты.");
Console.WriteLine("Введите координаты Х1: ");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты Y1: ");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты Z1: ");
double z1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты X2: ");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты Y2: ");
double y2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты Z2: ");
double z2 = double.Parse(Console.ReadLine());
double result =  Math.Pow((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2) * 1.0), 0.5);
Console.WriteLine($"Расстояние между точками равно - {result} .");