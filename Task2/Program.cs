// Задача 67: Напишите программу, 
// которая будет принимать на вход 
// число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int m= 453;


int RecNumbers (int m)
{
    if(m == 0) return 0;
    
    return m%10 + RecNumbers(m/10);
}

Console.Write(RecNumbers(m));



