// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите целое число, возмодимое в степень, а затем степень возведения");

string DevPow() { 
    int A = Convert.ToInt32(Console.ReadLine());
    int B = Convert.ToInt32(Console.ReadLine());
    int result = A;
    for(int i = 1; i < B; i++) {
        result *= A;
    }
    return $"{A} в степени {B} = {result}";
}
Console.WriteLine(DevPow());