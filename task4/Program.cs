Console.WriteLine("Введите три числа:");
int max;
int i = 0;
int[] arr = new int[3];
while( i < arr.Length) {
    arr[i] = Convert.ToInt32(Console.ReadLine());
    i++;
} 

if ((arr[0] > arr[1]) && (arr[0] > arr[2])) {
    max = arr[0];
}
else if ((arr[1] > arr[0]) && (arr[1] > arr[2])) {
    max = arr[1];
}
else {
    max = arr[2];

}
Console.WriteLine("Максимальное число " + max);