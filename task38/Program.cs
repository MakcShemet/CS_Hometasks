/*адача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76  */

void MargElArray() {
    int size = Convert.ToInt32(Console.ReadLine());
    Random rand = new Random();
    double[] array = new double[size];
    double max = 0;        
    for (int i = 0; i < size; i++) {
        array[i] = rand.Next(1, 100);
        if (array[i] > max) {
            max = array[i];
            }      
    }
    double min = max;
    foreach (var num in array) {
        if (num < min) {
            min = num;
        }
    }
    double result = max - min;
    string str = string.Join(", ", array);
    Console.Write($"[{str}] Разница максимального и минимального чисел массива = {result}");
}
Console.WriteLine("Введите размер массива");    
MargElArray();