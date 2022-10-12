/*Задача 47. Задайте двумерный массив размером m × n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/


//КОД ОСНОВНОЙ ПРОГРАММЫ
int m = GetNumberFromConsole("Введите количество строк");
int n = GetNumberFromConsole("Введите количество столбцов");
double [,]array = new double [m,n];
FillArray(array);
PrintArray(array);


//МЕТОДЫ

int GetNumberFromConsole(string text)// метод получение данных с консоли в виде текста
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

double GetRandomValue()
{
    double array = new Random().Next(-100,100)/10.0;
    return array;
}


void FillArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = GetRandomValue();
        }
    }
}

void PrintArray(double[,] array)
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


