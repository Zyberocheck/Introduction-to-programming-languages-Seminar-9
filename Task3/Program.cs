// Задача 69: Напишите программу, 
// которая на вход принимает два 
// числа A и B, и возводит число А в 
// целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int RecNumbers(int m, int n)
{
    if (n==0) return 1;
    return m* RecNumbers(m,n-1);
}

Console.Write(RecNumbers(2,3));
