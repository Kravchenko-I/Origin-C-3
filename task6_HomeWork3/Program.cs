﻿// Напишите программу, которая принимает на 
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9. 
// 5 -> 1, 8, 27, 64, 125
// 3 -> 1, 8, 27 
// 5 -> 1, 8, 27, 64, 125
Console.Clear();
Console.WriteLine("Введите число: ");
long N = long.Parse(Console.ReadLine());
long count = 1;
while(count < N)
{
    Console.Write((count*count*count) +" , ");
    count++;
}
     Console.Write((count*count*count) +" . ");
