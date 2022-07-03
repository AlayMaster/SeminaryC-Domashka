// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int DoubleNumber()
{
    int num = new Random().Next(100,1000);
    Console.WriteLine("Random number is: " + num);
    int des = (num / 10) % 10;
    return des;
}

int number = DoubleNumber();
Console.WriteLine("Double number is: " + number);

*/
//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void Week(int x)
{
    if (x >= 1 && x <=5 ) Console.WriteLine("No");
    if (x >=6 && x <=7) Console.WriteLine("Yes");
    if (x >= 8) Console.WriteLine("Number is uncorrect");
}
Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
Week(num);
