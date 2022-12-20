﻿/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива. Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2  */

Console.WriteLine("Введите два числа для указания размера двумерного массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
if (m == 0 || n == 0)
    Console.WriteLine("Значения не должны быть нулевыми");

SortToMinArray();

int[,] CreateArray()
{   
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(1, 10);
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    Console.WriteLine();
    return array;       
}
void SortToMinArray()
{
    int[,] arraySort = CreateArray();
    for (int i = 0; i < arraySort.GetLength(0); i++)    
    {        
        for (int j = 0; j < arraySort.GetLength(1); j++)
        {    
            for(int k = 0; k < arraySort.GetLength(1) - 1; k++)  
            {     
            if (arraySort[i, k] < arraySort[i, k + 1])
                {
                    int temp = arraySort[i, k + 1];
                    arraySort[i, k + 1] = arraySort[i, k];
                    arraySort[i, k] = temp;                                      
                }   
               
            }                                            
        }
    }  
    for (int i = 0; i < arraySort.GetLength(0); i++)
    {
        for (int j = 0; j < arraySort.GetLength(1); j++)
        {
            Console.Write($"{arraySort[i,j]} ");
        }
        Console.WriteLine();
    }     
}