Console.WriteLine("Введите три целые числа:");
int[] arr = new int [3];
int max = arr[0];
for (int i = 0; i < arr.Length; i++) { 
    arr[i] = Convert.ToInt32(Console.ReadLine());          
    if (arr[i] > max) {
    max = arr[i];
    }
}
Console.WriteLine($"Максимальное число {max}");