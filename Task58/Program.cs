// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


Console.WriteLine("Введите количество строк: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns1 = Convert.ToInt32(Console.ReadLine());

int rows2 = columns1;
int columns2 = rows1;

Console.WriteLine("Матрица 1: ");
int[,] matrix1 = new int[rows1,columns1];

for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(1); j++)
    {
        matrix1[i,j] = new Random().Next(-30,31);
        Console.Write(matrix1[i,j]+"\t");

    }
    Console.WriteLine();
}
Console.WriteLine();

Console.WriteLine("Матрица 2: ");
int[,] matrix2 = new int[rows2,columns2];

for (int i = 0; i < matrix2.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        matrix2[i,j] = new Random().Next(-30,31);
        Console.Write(matrix2[i,j]+"\t");

    }
    Console.WriteLine();
}
Console.WriteLine(" ");
Console.WriteLine("Произведение матриц: ");

int[,] matrix12 = new int[matrix1.GetLength(0),matrix2.GetLength(1)];

for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        for (int k = 0; k < matrix2.GetLength(0); k++)
        {
            matrix12[i,j] += matrix1[i,k] * matrix2[k,j];

        }
        Console.Write(matrix12[i,j] + "\t");
    }
    Console.WriteLine();
}

