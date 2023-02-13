/*Задача 66: Задайте значения M и N. Напишите программу, которая 
найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int GetSum(int m, int n)
{
    if (m > n) return 0;
    else 
    {
        return m + GetSum(m+1, n);
    }
}

Console.WriteLine(GetSum(4,8));