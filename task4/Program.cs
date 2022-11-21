Console.WriteLine("Введите три числа:");
int max;
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

if (a > b && a > c) {
    max = a;
}
else if (b > c && b > a) {
    max = b;
}
else {
    max = c;
}
Console.WriteLine("Максимальное число " + max);