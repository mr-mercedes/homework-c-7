// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

Console.WriteLine("Задайте размер массива");
Console.Write("Введите количество строк: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[line, column];
FillArray(array);
PrintArray(array);
double avarageSum = 0;
for (int j = 0; j < column; j++)
{
    for (int i = 0; i < line; i++)
    {
        avarageSum = array[i,j] + avarageSum;
    }
    avarageSum = avarageSum / line;
    Console.Write(Math.Round(avarageSum, 1) + " " );
    avarageSum = 0;
}



void FillArray(int[,] array)
{
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}