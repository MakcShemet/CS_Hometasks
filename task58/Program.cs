/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

Console.WriteLine("Введите количетсво строк первой матрицы:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количетсво столбцов первой матрицы:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количетсво столбцов второй матрицы");
int x = Convert.ToInt32(Console.ReadLine());
if (m == 0 || n == 0 || x == 0)
    Console.WriteLine("Значения не должны быть нулевыми");

int[,] matrixOne = new int[m, n];
int[,] matrixTwo = new int[n, x];

CreateArray(matrixOne);
CreateArray(matrixTwo);

int[,] result = ResultMatrix(matrixOne, matrixTwo);

Console.WriteLine("Первая матрица:");
PrintArray(matrixOne);
Console.WriteLine("Вторая матрица:");
PrintArray(matrixTwo);
Console.WriteLine("Результирующая матрица:");

PrintArray(result);

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
    for (int i =0; i < array.GetLength(0); i++)
    {
        for (int j =0; j < array.GetLength(1); j++)
        Console.Write($"{array[i,j],3} ");
        Console.WriteLine();
    }
}
int[,] ResultMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }

    }
    return resultMatrix;
}