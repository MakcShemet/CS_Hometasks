/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

Console.WriteLine("Введите количетсво строк массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количетсво столбцов массива");
int n = Convert.ToInt32(Console.ReadLine());
if (m == 0 || n == 0)
    Console.WriteLine("Значения не должны быть нулевыми");

int[,] array = new int[m, n];

CreateArray(array);
PrintArray(array);
Console.WriteLine();
FindString();

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[] CountSumInString(int[,] array)
{
    int[] sumArray = new int[m];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        int res = sum;
        sumArray[i] = res;
    }
    return sumArray;
}
void FindString()
{
    int[] findString = CountSumInString(array);
    int numberString = 0;
    int el = findString[0];
    for (int i = 0; i < findString.Length-1; i++)
    {
         if (findString[i] < el)
        {
            el = findString[i];
            numberString = i;
        }
    }
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {numberString + 1} строка");
}