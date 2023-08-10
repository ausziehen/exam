/* 
Задача 64: Задайте значение N. Напишите программу,которая выведет 
все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void Numbers (int num)
{
   Console.Write(num + " ");  
   if (num > 1) Numbers(num - 1);
}
Console.WriteLine("Введите число: ");
int numb = Convert.ToInt32(Console.ReadLine());
Numbers(numb);
*/




/*
Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumNumb (int m, int n)
{
    if (m == n) return m;
    if (m < n)  return  m + SumNumb(m + 1, n);
    else return n + SumNumb(n + 1, m);         
}
Console.WriteLine ("Введите 1 число (m): ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите 2 число (n): ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine (SumNumb(num1, num2));
*/




/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.

int Akkerman(int m, int n)
{
if (m == 0) return n + 1;
else if (n == 0) return Akkerman(m - 1, 1);
else return Akkerman(m - 1, Akkerman(m, n - 1));
}
Console.Write("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"Функция Аккермана = {Akkerman(m,n)}");
*/
