// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт 
// сумму натуральных элементов в 
// промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int m= 4;
int n= 8;
int RecNumbers (int m, int n)
{
    int sum=m;
    if(m==n)
    {
    return 0;
    }else
    {
        m++;
        sum = m + RecNumbers(m,n);
        return sum;
    }

}

Console.WriteLine(RecNumbers(m - 1,n));


// 1 55