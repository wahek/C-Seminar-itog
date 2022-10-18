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

Console.WriteLine("Введите первое число: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int M = int.Parse(Console.ReadLine()!);
if(N > M){
    int temp = N;
    N = M;
    M = temp;
}
if(M == N) Console.WriteLine(N);
else{Console.WriteLine(GetSumFromMinToMax(N, M));
}

int GetSumFromMinToMax(int n, int m){
    if(n == m) return(m);
    else return n + GetSumFromMinToMax(n + 1, m);
}