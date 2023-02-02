// -------------------------------Домашняя работа--------------------------------

// Задача 64: **Выполнить с помощью рекурсии**.Задайте значение N.
//  Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.Write("Введите число N: ");
// int N = int.Parse(Console.ReadLine()!);

// Console.WriteLine(PrintNumbersReverce(N,1));

// // -------------------метод---------------------------------

// string PrintNumbersReverce(int num, int end){
//     if(num == end) return num.ToString();
//     return (num + " " + PrintNumbersReverce(num - 1, end));
// }

// ----

// Задача 66: **Выполнить с помощью рекурсии**. Задайте значения M и N.
//  Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N..
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Write("Введите значение M: ");
// int M = int.Parse(Console.ReadLine()!);
// Console.Write("Введите значение N: ");
// int N = int.Parse(Console.ReadLine()!);
// int Sum = M;
// Console.WriteLine(PrintNumbersSum(Sum));

// // ----------------------метод---------------------------

// int PrintNumbersSum(int nums){
//     if(nums == N) return nums;
//     return(nums + PrintNumbersSum(nums + 1));

// }

// -----

// Задача 68: Выполнить с помощью рекурсии. Напишите программу вычисления функции Аккермана
//  с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите значение M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение N: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine();

Console.WriteLine(PrintAcc(M, N));

// ----------------------метод---------------------------

int PrintAcc(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return PrintAcc(n - 1, 1);
    else
      return PrintAcc(n - 1, PrintAcc(n, m - 1));
}
