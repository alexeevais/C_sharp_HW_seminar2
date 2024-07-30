// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

// Пример:
// 568 => 5,6,8
// 8 => 8
// 9542 => 9,5,4,2

Console.WriteLine("Введите целое число и нажмите Enter:");
int number = Convert.ToInt32(Console.ReadLine());

// int a = number % 10;
// int b = number / 10 % 10;
// int c = number / 10 / 10 % 10;
// Console.Write($"{c}, {b}, {a}");

string s = number.ToString();
int i = 1;
// Console.WriteLine(s.Length);
for (int j = 1; j <= s.Length; j++)
{
    int a = number / i % 10;
    Console.Write(a);
    i=i*10;
}

