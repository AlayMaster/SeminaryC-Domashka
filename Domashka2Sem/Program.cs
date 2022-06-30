// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int DoubleNumber()
{
    int num = new Random().Next(100,1000);
    Console.WriteLine("Random number is: " + num);
    int des = (num / 10) % 10;
    return des;
}

int number = DoubleNumber();
Console.WriteLine("Double number is: " + number);

//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
