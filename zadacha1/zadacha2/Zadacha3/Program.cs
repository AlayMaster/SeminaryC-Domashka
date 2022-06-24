// Задача3
int num;

Console.Write("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine(num + " - Это число четче некуда");
}
else
{
    Console.WriteLine(num + " - Число совсем не четное");
}

