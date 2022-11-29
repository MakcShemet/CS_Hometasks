Console.WriteLine("Введите любое целое число:");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= N; i++) { 
    if ((i % 2) != 1) { 
        Console.Write(i + ", ");
    }
}