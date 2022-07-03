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

void Week(int x)
{
    if (x >= 1 && x <=5 ) Console.WriteLine("No");
    if (x >=6 && x <=7) Console.WriteLine("Yes");
    if (x >= 8) Console.WriteLine("Number is uncorrect");
}
Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
Week(num);

//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int ThirdNumber()
{
    Console.WriteLine("Input number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num < 100) Console.WriteLine("третьего числа нет");
    if (num > 999 && num <=9999)
        num = num / 10;
        int res = num % 10;
  /*   while (num>=9999)  // чет я голову ломал,так и не додумался как порядок понижать до этих трех цифр
    {
        int k=10;
        num = num / 10*k;
        int res2 = num % 10;
        return res2;
    }
    */
     
    return res; 
}

int number = ThirdNumber();
Console.WriteLine("Third number is: " + number);
