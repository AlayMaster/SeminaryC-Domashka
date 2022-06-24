// Задача2
int num1, num2, num3, max;

Console.Write("Введите первое число: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
num3 = Convert.ToInt32(Console.ReadLine());

max = num1;

if (num2 > num1)
{   
    max = num2;
}
if (num3 > num2)
{ 
    max = num3;
} 

Console.WriteLine("Максимальное число:" + max);
