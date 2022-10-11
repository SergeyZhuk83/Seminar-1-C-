﻿using System;
using System.Linq;
int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
            Console.Write( result[i, j] + "\t");
        }
        Console.WriteLine();

    }
    return result;
}
int[] GoodArray(int[,] matrix, int[] array)
{
   int[] outs = new int[array.Length];
   for (int i = 0; i < array.Length; i++)
   {
      for (int x = 0; x < matrix.GetLength(0); x++)
      {
         for (int y = 0; y < matrix.GetLength(1); y++)
         {
            if(array[i] == matrix[y,x]){
                outs[i]++;
            }
         }
      }
   }
   return outs;
}

int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();// 2367
int[] good = GoodArray(GetArray(6,6,-10,10), array);
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Число {array[i]} = {good[i]}");
}

