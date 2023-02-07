// Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, является ли 
// оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Clear();
Console.WriteLine("Введите число");
string text =Console.ReadLine();
char[] userInsert =text.ToCharArray();
Array.Reverse(userInsert);
string finalText = new String(userInsert);
if(text == finalText)
{
   Console.WriteLine("Число палиндром.");
}
if(text != finalText)
{
    Console.WriteLine("Число не палиндром.");
}


// Console.WriteLine("Введите число: ");
// string number = Console.ReadLine();
// int len = number.Length;

// if (len == 5)
// {
//     if (number[0] == number[4] && number[1] == number[3])
//     {
//         Console.WriteLine($"{number} - Палиндром");
//     }
//     else
//     {
//         Console.WriteLine($"{number} - НЕ палиндром");
//     }
// }
// else
// {
//     Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
// }
// Нашел в интернете.Тоже работает, но мне кажется что первый способ который разбирали на уроке применим к любой длинне числа,
//  и соответственно лучше.Только вот вопрос какой лучше писать на собеседовании? 





