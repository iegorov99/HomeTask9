// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akkerman(int numA, int numB)
{
    if (numA == 0) return numB+1;
    else if (numB == 0) return Akkerman(numA-1, 1);
    else return Akkerman(numA-1, Akkerman(numA, numB-1));
}


Console.Write("Введите 1 натуральное число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 натуральное число: ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Akkerman(numA, numB));