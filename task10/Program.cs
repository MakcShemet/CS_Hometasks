Console.WriteLine("Введите трехзначное число:");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 100 && a > 999) {
    Console.WriteLine("Число не трехзначное");
}
else {
    int b = (a / 10) % 10;
    Console.WriteLine($"Вторая цифра числа {a} это {b}");
}