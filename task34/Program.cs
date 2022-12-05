/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

void evCount() {
    int n = int.Parse(Console.ReadLine());
    int[] arr = new int[n];
    string str = string.Empty;
    string num = "четных чисел";
    int count = 0;
    for(int i = 0; i < arr.Length; i++) {
        arr[i] = new Random().Next(100, 1000);        
        if(arr[i] % 2 == 0)
        count++;
        str += $"{arr[i]},";
    }
    if(count > 1 && count < 5) 
    num = "четных числа";
    else if(count == 1)
    num = "четное число";
    Console.WriteLine($"В массиве [{str}] {count}  {num}");
}
Console.WriteLine("Задайте длинну массива:");
evCount();