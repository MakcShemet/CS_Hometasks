/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.   */

int [,] CreateRandArray () {  
    int m = Convert.ToInt32(Console.ReadLine());
    int n = Convert.ToInt32(Console.ReadLine());  
    int[,] arr = new int[m,n];                                      // Создаем двумерный массив размером m на n
    for(int i = 0; i < arr.GetLength(0); i++) {
        for(int j = 0; j < arr.GetLength(1); j++) {
            arr[i,j] = Convert.ToInt32(new Random().Next(1, 10));   // Заполняем массив рандомными числами
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
    return arr;
}

void FindArithmeticMean() {
    int[,] array = CreateRandArray();
    double[] mean = new double[array.GetLength(1)];
    double arithMean = 0;
    int td = 0;    
    for(int i = 0; i < array.GetLength(1); i++) {        
            for(int j = 0; j < array.GetLength(0); j++) {
               td += array[j,i];                                 // Записываем сумму значений элементов столбца               
        }   
        arithMean = Convert.ToDouble(td) / array.GetLength(0); // Находим среднее арифметическое, тип данных double
        td = 0;                                                //Обнуляем сумму для подсчета следующего столбца
        mean[i] = Math.Round(arithMean, 1);
        }
        string str = string.Join("; ", mean);
        Console.Write($"Среднее арифметическое каждого столбца: {str}.");       
}
Console.WriteLine("Введите количество строк и столбцов для двумерного массива:");
FindArithmeticMean();