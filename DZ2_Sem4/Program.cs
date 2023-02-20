// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


int GetNumber(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int A = GetNumber("Введите число A: ");

int sum = 0;
while (A > 0)
{
    sum = sum + A % 10;
    A = A / 10;
}

Console.WriteLine($"Сумма всех цифр в числе = {sum}.");
