﻿/*Задача 68: Напишите программу вычисления функции Аккермана с 
помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

int AkFunction(int m, int n)
{
    if (m == 0) return n+1;
    else if (n == 0) return AkFunction(m-1,1);
        return AkFunction(m-1, AkFunction(m, n-1));
}

Console.WriteLine(AkFunction(3,2));