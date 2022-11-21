Console.WriteLine("Введите три числа:");
int i = 0;
int[] arr = new int[3];
int max = arr[0];
while( i < arr.Length) {
    arr[i] = Convert.ToInt32(Console.ReadLine());    
    if (arr[i] > max) {
    max = arr[i];
    i++;
    }
    else {
        i++;
    }
}
Console.WriteLine("Максимальное число " + max);