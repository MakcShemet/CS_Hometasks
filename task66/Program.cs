/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30  */

Console.WriteLine("Введите начально целое число:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное целое число:");
int N = Convert.ToInt32(Console.ReadLine());
if (N < M)
    (M, N) = (N, M);

int PrintNumbers(int m, int n)
{
    if (m == n) return n;
    return PrintNumbers(m + 1, n) + m;
}
Console.WriteLine($"Сумма натуральных елементов в промежутке от {M} до {N} равна {PrintNumbers(M, N)}");