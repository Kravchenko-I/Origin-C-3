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







