﻿// Знакомство с языками программирования (семинары)

// Урок 5. Двумерные Массивы

// Задача 1: Напишите программу, которая на вход принимает
// позиции элемента в двумерном массиве, и возвращает
// значение этого элемента или же указание, что такого
// элемента нет.

// Пример: 4 3 1 (1,2) => 9
//         2 6 9

// Решение:

Console.WriteLine("Введите номер строки");
int Row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int Col = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[2, 3];

void CreateArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

CreateArray();
PrintArray();

if ((Row < 0 || Col < 0) || (Row > array.GetLength(0)-1 || Col > array.GetLength(1)-1))
{
    Console.WriteLine("Такого элемента нет");
}
else
{
    Console.WriteLine("Значение этого элемента = " + array[Row, Col]);
}