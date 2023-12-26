// Знакомство с языками программирования (семинары)

// Урок 5. Двумерные Массивы

// Задача 1: Напишите программу, которая на вход принимает
// позиции элемента в двумерном массиве, и возвращает
// значение этого элемента или же указание, что такого
// элемента нет.

// Пример: 4 3 1 (1,2) => 9
//         2 6 9

// Решение:

// Console.WriteLine("Введите номер строки");
// int Row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите номер столбца");
// int Col = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[2, 3];

// void CreateArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// CreateArray();
// PrintArray();

// if ((Row < 0 || Col < 0) || (Row > array.GetLength(0)-1 || Col > array.GetLength(1)-1))
// {
//     Console.WriteLine("Такого элемента нет");
// }
// else
// {
//     Console.WriteLine("Значение этого элемента = " + array[Row, Col]);
// }

// -----------------------------------------------

// Задача 2: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.

// Пример:  4 3 1 => 4 6 2
//          2 6 9    2 6 9
//          4 6 2    4 3 1

// Решение:

// Console.WriteLine("Введите количество строк");
// int Row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int Col = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[Row, Col];

// void CreateArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void ChangeArray()
// {
//     // можно через одномерный массив

//     // int[] temp = new int[array.GetLength(0)];
//     // for (int i = 0; i < array.GetLength(0); i++)
//     // {
//     //     for (int j = 0; j < array.GetLength(1); j++)
//     //     {
//     //         if (i == 0)
//     //         {
//     //             temp[j] = array[i, j];
//     //             array[i, j] = array[array.GetLength(0) - 1, j];
//     //             array[array.GetLength(0) - 1, j] = temp[j];
//     //         }
//     //     }
//     // }

//     // можно упростить

//     int temp = 0;
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         temp = array[0, i];
//         array[0, i] = array[array.GetLength(0) - 1, i];
//         array[array.GetLength(0) - 1, i] = temp;
//     }
// }

// CreateArray();
// Console.WriteLine("\nПервоначальный массив\n");
// PrintArray();
// ChangeArray();
// Console.WriteLine("Заменены местами строки массива\n");
// PrintArray();

// -----------------------------------------------

// Задача 3: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.

// Пример:  4 3 1 => Строка с индексом 0
//          2 6 9
//          4 6 2

// Решение:

Console.WriteLine("Введите количество строк");
int Row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int Col = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[Row, Col];

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

int FindRowMinSum()
{
    int minSum = 0;
    int indexMin = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (i == 0)
        {
            minSum = sum;
        }
        //Console.WriteLine($"min = {minSum} sum = {sum}");
        if (sum < minSum)
        {
            minSum = sum;
            indexMin = i;
        }
    }
    return indexMin;
}

CreateArray();
PrintArray();
Console.WriteLine("Строка с наименьшей суммой элементов = " + FindRowMinSum());