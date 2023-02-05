// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
Console.Clear();
Console.WriteLine("Введите координаты.");

Console.WriteLine("Введите Х1: ");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите Х2: ");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите Y1: ");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите Y2: ");
double y2 = double.Parse(Console.ReadLine());  
double result = Math.Sqrt((Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)));
Console.WriteLine($"Расстояние между точками -{result}.");
