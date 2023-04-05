// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Values(int numA, int numB)
{
    if (numA > numB) return 0;
    return numA + Values(numA+1, numB);
}


Console.Write("Введите 1 натуральное число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 натуральное число: ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Values(numA, numB));
