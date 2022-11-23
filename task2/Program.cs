Console.WriteLine("Введите два числа:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a > b) {
    Console.WriteLine("Число " + a + " больше числа " + b);
}
else if (b > a) {
    Console.WriteLine("Число " + a + " меньше числа " + b);
}
else {
    Console.WriteLine($"Числа {a} и {b} равны");
}