// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4


 
double[,] array = new double [3,3];
Random mas =new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = mas.NextDouble();
    }
}

System.Console.Write("Введите номер строки от 0 до 2: ");
int row = int.Parse(System.Console.ReadLine());
System.Console.Write("Введите номер столбца от 0 до 2: ");
int col = int.Parse(System.Console.ReadLine());

if (row >= 0 && row<array.GetLength(0) && col >= 0 && col < array.GetLength(1))
{
   System.Console.WriteLine("Значение элемента: " + (Math.Pow((array[row, col]),2)));
}
else
{
    System.Console.WriteLine("Ошибка, указанные позиции находятся за пределами массиваю");
}














