﻿// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество элементов по оси Z: ");
int elementz = Convert.ToInt32(Console.ReadLine());

if (rows*columns*elementz > 90)
{
    Console.WriteLine("Недостаточно чисел для заполнения массива ");
}

else
{
    int count = 0;
    int [] arrayRandom = new int[90];
    for(int i=0; i < arrayRandom.Length -1; i++)
    {
        arrayRandom[i] = 10 + i;
    }

    for(int i=0; i < arrayRandom.Length; i++)
    {
        int j = new Random().Next(arrayRandom.Length);
        int temp = arrayRandom[j];
        arrayRandom[j] = arrayRandom[i];
        arrayRandom[i] = temp;

    }

    int[,,] array = new int[rows,columns,elementz];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
                array[i,j,k] = arrayRandom[count];
                Console.Write($"{array[i,j,k]}({i},{j},{k})");
                count +=1;
            }
            Console.WriteLine();
        }
    }



}
