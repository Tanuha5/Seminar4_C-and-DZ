// Задача 26: Напишите программу, которая принимает 
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

string? GetNumber(string text)
{
    System.Console.Write(text);
    return (Console.ReadLine());
}
string? num = GetNumber("Введите число А: ");
int len = num!.Length;
System.Console.WriteLine($"Количество цифр в числе {num} = {len}.");
