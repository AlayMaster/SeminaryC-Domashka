//Задача 1: Задайте значение N. Напишите программу, 
//          которая найдет кол-во цифр в числе N рекурсивным методом.

Console.Write("Input number N: ");
int m = Convert.ToInt32(Console.ReadLine());
int NumberOfDigits(int n)
{
    int count = 0;
    if(n % 10 > 0)
    {
        count++;
        return count += NumberOfDigits(n / 10);
    }
    return count;
}
Console.WriteLine(NumberOfDigits(m));

// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму 
//           натуральных элементов в промежутке от M до N.

Console.Write("Input first number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number N: ");
int n = Convert.ToInt32(Console.ReadLine());

int SumofDigits(int m, int n)
{   
    if (n > m) 
    {
        return n + SumofDigits(m,n-1);
    }
    return n;
}
Console.WriteLine(SumofDigits(m,n));