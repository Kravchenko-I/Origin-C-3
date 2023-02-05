// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
Console.Clear();
Console.WriteLine("Введите Интересующую вас четверть: ");
int quarter = int.Parse(Console.ReadLine());
if ((quarter > 4) || (quarter < 1))
{
    Console.WriteLine("Нет такой четверти..");
}
else if (quarter == 1)
{
    Console.WriteLine("Первая четверть координаты X > 0 и Y > 0");
}
if (quarter == 2)
{
    Console.WriteLine("Вторая четверть координаты X < 0 и Y > 0");
}
if (quarter == 3)
{
    Console.WriteLine("Третья четверть координаты X < 0 и Y < 0");
}
if (quarter == 4)
{
    Console.WriteLine("Четвертая четверть координаты X > 0 и Y < 0");
}