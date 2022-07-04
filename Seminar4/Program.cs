// Seminar 3
//

int  FindSum (int a)

{
  int sum = 0;
  for(int current =1; current <= a ;current ++)
      sum +=current; //sum = sum +current 
  return sum;
}

Console.WriteLine("input positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"sum of numbers from 1 to {num} is {FindSum(num)}");

// произведение до N

int  Fact (int a)

{
  int pro = 1;
  for(int current =1; current <= a ;current ++)
      pro = pro*current; 
  return pro;
}

Console.WriteLine("input positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Factorial from 1 to {num} is {Fact(num)}");


// сколько цифр в числе

int Chisla(int num)
{
    int count = 0;
    if (num == 0) count = 1;
    else
      while ( num > 0)
     {
      num = num/10 ;
      count++;
     } 
    
    return count;
    

}
Console.WriteLine("input integer number: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Chisla(N));

//


int Step(int a , int b )
{
    int result = 1;
    int count = 1;
    while (count <= b )
    {
     result = result*a;
     count++;
    }
    return result;
}

Console.WriteLine("input first number: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input second number: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Step(A,B));
