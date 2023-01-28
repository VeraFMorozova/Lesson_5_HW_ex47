//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan; 
    Console.WriteLine(message);
    Console.ResetColor();
    int UserData = int.Parse(Console.ReadLine()!);
    return UserData;
}

void printInColor(string data)
{
    Console.ForegroundColor = ConsoleColor.Magenta; 
    Console.Write(data);
    Console.ResetColor();
}

double[,] get2DDoubleArray(int colLength, int rowLength, int start, int end)
{
   double[,] array = new double[colLength, rowLength];
   const int divider = 100;
   for (int i = 0; i < colLength; i++)
   {
        for (int j = 0; j < rowLength; j++)
        {
            array[i,j] = new Random().Next(start * divider , (end+1) * divider) / (divider + 0.0);
        }
   }
   return array; 
}

void print2DArray(double[,] array)
{
    Console.Write( "\t");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        printInColor(j + "\t");
    }
    Console.WriteLine();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        printInColor(i + "\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write(array[i,j] + "\t"); 
        }
        Console.WriteLine();
    }
}

int number_n = getUserData("Введите количество строк");
int number_m = getUserData("Введите количество столбцов");
double[,] array = get2DDoubleArray(number_n, number_m, -10, 10);
print2DArray(array);
