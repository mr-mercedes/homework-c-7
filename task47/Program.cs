/* Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

Console.WriteLine("Введите размер массива");
Console.Write("Введите количество строк: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
double[,] array = new double [line, column];
FillArray(array);
WriteArray(array);


void WriteArray (double[,] array)
{
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void FillArray (double[,] array)
{
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
            {
            array[i, j] = Math.Round(new Random().NextDouble(), 1) + new Random().Next(-10, 10);
            }
    }
}
