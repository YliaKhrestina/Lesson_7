﻿// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



int [,] array = new int[,]
{
    {1,4,7,2},
    {5,9,2,3},
    {8,4,2,4}
};

int row = array.GetLength(0);
int col = array.GetLength(1);

double[] columnAverages = new double [cols];
for (int j = 0; j < cols; j++)
{
    double sum = 0;
    for (int i = 0; i < rows; i++)
    {
        sum += array[i,j];
    }
    columnAverages[j] = sum/rows;
}

for (int j = 0; j < cols; j++)
{
    System.Console.WriteLine($"Среднее арифметическое элементов каждом столбце {j+1}: {columnAverages[j]}");
}













