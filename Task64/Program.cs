// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string Values(int num, int count = 1)
{
    string result = String.Empty;
    if (count == num) return Convert.ToString(count);
    return Values(num, count+1) + " " + Convert.ToString(count);
}


Console.Write("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Values(num));