// Задача 1
int num1, num2;

Console.Write("Введите первое число: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("Большее число" + num1 );
}
if (num1 < num2)
{
    Console.WriteLine("Большее число" + num2 );
}
if (num1 == num2)
{
    Console.WriteLine("Вы ввели равные числа");
}

