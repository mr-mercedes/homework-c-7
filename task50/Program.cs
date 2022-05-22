// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

Console.WriteLine("Введите размер массива");
Console.Write("Введите количество строк: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");         
int column = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[line, column];
FillArray(array);
PrintArray(array);
string? position = string.Empty;
while (position.Length != 2)
{
    Console.Write("Введите позицию элемента массива: ");
    position = Console.ReadLine();
    if (position.Length != 2) Console.WriteLine("Массив двумерный, Введите двухзначное число");
}
int positionLine = 0;
int positionColumn = 0;
int convertChar = 48;
for (int i = 0; i < position.Length; i++)
{
    positionLine = position[0] - convertChar;
    positionColumn = position[1] - convertChar;
}
if (positionLine > line || positionColumn > column) Console.WriteLine($"Элемента {position} нет в массиве");
for (int i = 0; i < line; i++)
{
    if (i == positionLine)
    for (int j = 0; j < column; j++)
    {
        if (j == positionColumn) Console.Write($"Значение элемента {position} в массиве: {array[positionLine, positionColumn]}");
    }
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
void PrintArray (int[,] array)
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