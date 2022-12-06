/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
void randArray() {
    int[] arr = new int[8];
    string str =  String.Empty;
    for(int i = 0; i < arr.Length; i++) {
        arr[i] = new Random().Next(1, 100);
        str += $"{arr[i]}, ";
    }
    Console.WriteLine($"[{str}]");
}
randArray();