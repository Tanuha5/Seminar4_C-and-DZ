// // Задача 25: Напишите цикл, который принимает на вход 
// // два числа (A и B) и возводит число A в натуральную степень B.

// // 3, 5 -> 243 (3⁵)
// // 2, 4 -> 16

int GetNumber(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int a = GetNumber("Введите число A: ");
int b = GetNumber("Введите число B: ");

int result = a;

for (int i = 1; i < b; i++)
{
result = result * a;
}
Console.WriteLine("Число A в степени B равно: " + result);

