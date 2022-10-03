using System;
// Задача №25 
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в
// натуральную степень B.

Console.WriteLine("введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int b = Convert.ToInt32(Console.ReadLine());
int step = a;

for (int i = 1; i < b; i++)
{
step = step * a;
}
Console.WriteLine("A в степени B равно: " + step);

// Задача №27 
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в
// числе.


Console.WriteLine("введите число");
int j = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (j > 0)
{
int num = j % 10;
j = j / 10;
sum = sum + num;
}
Console.WriteLine("сумма всех цифр в числе равна: " + sum);


// Задача №29 
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] CreateArray()
{
    int[] numbers = new int[8];
    int count = 0;
    int number = 0;
    while (number != 999 && count < 8)
    {
        Console.Write("Введите число " + (count + 1) + ": ");
        number = int.Parse(Console.ReadLine()??"0");
        if (number == 999) break;
        numbers[count] = number;
        count++;
    }
    return numbers;
}
void PrintArray(int[] numbers)
{
    Console.Write("[");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]} ");
    }
    Console.Write("]");
}
Console.WriteLine("Введите числа в массив");
int[] numbers = new int[8];
numbers = CreateArray();
PrintArray(numbers);