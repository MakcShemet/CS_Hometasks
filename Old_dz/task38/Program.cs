/*адача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76  */

double[] CreateArray(int size) {    
    double[] array = new double[size];           
    for (int i = 0; i < size; i++) {
        array[i] = new Random().Next(1, 100);              
    }
    return array;
}
void MargElArray(double[] arr) {
    double max = 0;    
    double min = 0;
    for (int i = 0; i < arr.Length; i++) {
        if (arr[i] > max) {
            max = arr[i];            
        }         
        min = max;
        for(int j = 0; j < arr.Length; j++) {
            if (arr[j] < min) {
                min = arr[j];
            }
        }  
    }  
    double result = max - min;
    string str = string.Join(", ", arr);
    Console.Write($"[{str}] Разница максимального и минимального чисел массива = {result}");
}
Console.WriteLine("Введите размер массива"); 
int size = Convert.ToInt32(Console.ReadLine()); 
double[] arr = CreateArray(size);
CreateArray(size);
MargElArray(arr);