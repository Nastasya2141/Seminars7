// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.


// ОСНОВНОЙ КОД
int m = GetNumberFromConsole("Введите количество строк");
int n = GetNumberFromConsole("Введите количество столбцов");
int [,]array = new int[m,n];
FillArray(array);
PrintArray(array);
AverageOfColumn(array);



//МЕТОДЫ

int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int GetRandomValue()
{
    int array = new Random().Next(1,100);
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

void AverageOfColumn(int[,] array)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
         sum = sum + array[j, i];
          if (j == (array.GetLength(0) - 1))
           {

             Console.WriteLine($"Среднее арефметическое столбца {i} равно "+((sum / (j + 1))));
             sum = 0;
           }
        }       
    }
    
}




