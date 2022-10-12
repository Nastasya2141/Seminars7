/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
*/

// ОСНОВНОЙ КОД
int m = GetNumberFromConsole("Введите количество строк");
int n = GetNumberFromConsole("Введите количество столбцов");
int [,]array = new int[m,n];
FillArray(array);
PrintArray(array);
FindElement (array);

//МЕТОДЫ

int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int GetRandomValue()
{
    int array = new Random().Next(-100,100);
    return array;
}

void FillArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = GetRandomValue();
        }
    }
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

void FindElement (int[,] array)
{
Console.WriteLine("Введите номер строки");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int m = Convert.ToInt32(Console.ReadLine());
if (n > array.GetLength(0) || m > array.GetLength(1))
{
    Console.WriteLine("Такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {array[n-1,m-1]}");
}
}