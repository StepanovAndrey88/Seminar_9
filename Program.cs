
// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
PrintNumber (N);
void PrintNumber (int N)
{
    if (N<1)
    {
        return;
    }
    Console.Write(N+ " ");
    PrintNumber (N-1);
}

// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int M = ReadInt("Введите число М");
int N = ReadInt("Введите число N");
int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Сумма натуральных элементов в промежутке от " + M + " до " + N + " = " + Sum(M, N));
int Sum(int M, int N)
{
    if (M == N)
    {
        return M;
    }
    else
    {
        return M + Sum(M + 1, N);
    }
}

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int m = ReadInt("Введите число М");
int n = ReadInt("Введите число N");
int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}
Console.WriteLine(Ackermann(m, n));

