// Задача 29: Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
// 6, 1, 33 -> [6, 1, 33]


int[] GetArray(int size, int leftRange, int rightRange)
{
int[] array = new int[size];
var rand = new Random();
for (int i = 0; i < array.Length; i++)
{
array[i] = rand.Next(leftRange, rightRange);
}
return array;
}

void PrintArray(int[] array)
{
System.Console.WriteLine("["+string.Join(", ", array)+"]");
}

var myArray = GetArray(5, 1, 20);
PrintArray(myArray);
