//  Напишите программу, которая задаёт массив из m элементов и выводит их на экран.


Console.WriteLine("input positive integer number: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] count;
count = new int[m];
for (int i = 0; i < m; i++)
{
  count[i] = new Random().Next(0, 100);
  Console.Write($"{count[i]} ");
}
Console.ReadLine();


//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumDigit( int a )
{
  int result = 0;
  while (a > 0)
 {
   result = result + a % 10;
    a = a / 10;
 }
    return result;   
}

Console.WriteLine("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Summa of digits {num} is {SumDigit(num)}");
