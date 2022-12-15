/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет  */

int [,] CreateRandArray () {    
    int[,] arr = new int[3,4];                                      // Создаем двумерный массив размером 3 на 4
    for(int i = 0; i < arr.GetLength(0); i++) {
        for(int j = 0; j < arr.GetLength(1); j++) {
            arr[i,j] = Convert.ToInt32(new Random().Next(1, 10));   // Заполняем массив рандомными числами
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
    return arr;
}

void FindElement(int m, int n) {
    int[,] array = CreateRandArray();
    int val = 0;
    if(m <= array.GetLength(0) && n <= array.GetLength(1)) {        // Проверяем наличие позиции элемента
     for(int i = 0; i < array.GetLength(0); i++) {
            for(int j = 0; j < array.GetLength(1); j++) {
            if(i == (m - 1) && j == (n - 1))
            val = array[--m,--n];                                   // Записываем значение найденной позиции
        }          
       }
       Console.WriteLine($"Значение искомого элемента равно {val}");
    }
    else 
    Console.WriteLine($"{m}{n} - такого элемента в массиве нет");
}

Console.WriteLine("Введите номер строки и столбца искомого элемента:");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
FindElement(m,n);