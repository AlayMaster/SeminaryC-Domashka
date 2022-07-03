// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Cube(int x)
{
    int current = 1;
    while (current <= x)
    {
        int cube = current * current * current;
        Console.Write(cube + " ");
        current++;
    }
}
Console.WriteLine("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());
Cube(n);

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Palindrom(int num)
{
    if(num >= 10000 && num < 100000)
    {
        int a = num / 10000;
        int b = (num / 1000) % 10;
        int c = (num / 10) % 10;
        int d = num % 10;
        if (a == d && b == c) Console.WriteLine("Число палиндром");
        else
        Console.WriteLine("Число не палиндром");
    }
    else 
    Console.WriteLine("Number is uncorrect");
}
Console.WriteLine("Enter a five-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
Palindrom(num);