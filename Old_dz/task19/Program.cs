Console.WriteLine("Введите любое целое число:");
int n = int.Parse(Console.ReadLine());
int a;
int b = 0;
int i = n;
while(n > 0) {
    a = n % 10;
    b = (b*10) + a;
    n = n / 10;
    }
if(i == b) {
    Console.WriteLine($"Введенное число палиндром");   
}
else {
Console.WriteLine($"Введенное число не палиндром");
} 
