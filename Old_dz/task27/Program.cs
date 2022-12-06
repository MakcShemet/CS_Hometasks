/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
Console.WriteLine("Ввведите целое число:");
string SumNum() {
    int n = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int [Convert.ToString(n).Length];   
    int sum = 0; 
    for(int i = 0; i < arr.Length; i++) {
       int a = n % 10;
       arr[i] = a;
       n /= 10;   
       sum = sum + arr[i];    
    } 
    return $"Сумма цифр введенного числа равна {sum}";
}
Console.WriteLine(SumNum());