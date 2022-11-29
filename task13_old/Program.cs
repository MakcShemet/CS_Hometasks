Console.WriteLine("Введите число:");
string a = Console.ReadLine();
if (Convert.ToInt32(a) < 100) {
    Console.WriteLine("Третьей цифры нет");
}
else {
    char[] arr = new char[a.Length];
        for (int i = 0; i< a.Length; i++) {
        arr[i] = a[i];
        } 
    Console.WriteLine("Третья цифра: " + arr[2]);
}