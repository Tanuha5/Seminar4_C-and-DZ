﻿// Задача 24: Напишите программу, которая принимает 
// на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
// Решение через функции

int GetNumber(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int GetSumElements (int A)
{
    int result = 0;
    for (int i = 1; i <=A; i++)
    {
        result +=i; // result = result + i;
    }
    return result;
}
int num = GetNumber("Введите число А: ");
System.Console.WriteLine($"Сумма чисел от 1 до {num} = {GetSumElements(num)}");

