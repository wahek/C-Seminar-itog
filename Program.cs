// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.WriteLine("Введите число N: ");
// int N = int.Parse(Console.ReadLine()!);
// PrintNumbers(N);

void PrintNumbers(int n)
{
    if (n == 1) Console.Write("1");
    else
    {
        Console.Write($"{n},");
        PrintNumbers(n - 1);
    }

}

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("Введите первое число: ");
// int N = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите второе число: ");
// int M = int.Parse(Console.ReadLine()!);
// if(N > M){
//     int temp = N;
//     N = M;
//     M = temp;
// }
// if(M == N) Console.WriteLine(N);
// else{Console.WriteLine(GetSumFromMinToMax(N, M));
// }

int GetSumFromMinToMax(int n, int m){
    if(n == m) return(m);
    else return n + GetSumFromMinToMax(n + 1, m);
}

// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите первое число: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int M = int.Parse(Console.ReadLine()!);
if (N < 0 || M < 0) Console.WriteLine("Читайте условие");
else
{
    Console.Write($"{FunctionAkkerman(N, M)}");
}
int FunctionAkkerman(int n, int m)
{
    if (n == 0) return m + 1;
    else if (n > 0 && m == 0) return FunctionAkkerman(n - 1, 1);
    else return FunctionAkkerman(n - 1, FunctionAkkerman(n, m - 1));
}