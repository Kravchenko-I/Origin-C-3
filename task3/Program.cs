// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
Console.Clear();
Console.WriteLine("Введите число: ");
Console.WriteLine("И получите таблицу квадратов чисел.");
int userInput = int.Parse(Console.ReadLine());
int counter = 1;
while(counter < userInput)
{
   Console.Write(counter*counter +" " );
   counter++;
}
   Console.WriteLine(counter*counter +" " );
