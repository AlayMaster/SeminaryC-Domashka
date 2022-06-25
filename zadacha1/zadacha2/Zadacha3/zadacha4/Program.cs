//Задача 4
int num,current;

Console.Write("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());

for (current = 1; current <= num; current++)
  if(current % 2 == 0)
  {
    Console.Write(current + " ");
    current++;
  }

 