/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

int[] InputNum () {
    Console.WriteLine("Введите число для ограничения ввода:");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите любые отрицательные и положительные числа:");
    int[] arr = new int[M];
    for(int i = 0; i < arr.Length; i++) {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }    
    return arr;
}
void CountNum() {
    int[] array = InputNum();
    int count = 0;
    foreach (int i in array) {
        if(i > 0)
        count++;
    }
    string s = "чисел";
    if(count > 1 && count < 5)
    s = "числа";
    else if(count == 1)
    s = "число";
    string str = string.Join(", ", array);
    Console.WriteLine($"В введенных вами числах ({str}) {count} {s} больше 0");
}
CountNum();