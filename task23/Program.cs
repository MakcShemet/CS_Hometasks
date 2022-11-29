Console.WriteLine("Введите любое целое число: ");
int N = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i <= N; i++)
    Console.Write(Math.Pow(i, 3) + ", ");