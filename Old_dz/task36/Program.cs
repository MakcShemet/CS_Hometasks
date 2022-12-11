/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

void noEventIndexCount() {
    int size = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[size];
    int sum = 0;
    for(int i = 0; i < arr.Length; i++) {
        arr[i] = new Random().Next(-100, 100);        
            if(i % 2 != 0) 
            sum += arr[i];        
    }
    string str = string.Join(", ", arr);
    Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях в массиве [{str}] равна {sum}");
}
Console.WriteLine("Задайте зазмер массива:");
noEventIndexCount();