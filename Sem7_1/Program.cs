using System;
// Задайте двумерный массив. Найдите сумму элементов, находящихся 
//на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
int rows=7;
int columns=5;

int len = rows < columns ? rows : columns;

int[,] array = GetArray(rows, columns);
PrintArray(array);
int sum = 0;
for (int i = 0; i < len; i++) 
{
    sum += array[i,i];
}
System.Console.WriteLine("Готовый вариант");
PrintArray(array);



int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++) 
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(1,10);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]}\t");
        }
        Console.WriteLine();
    }
}
