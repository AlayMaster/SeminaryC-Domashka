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
