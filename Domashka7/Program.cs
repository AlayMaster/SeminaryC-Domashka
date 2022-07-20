// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateRandom2dArray(int rows, int columns)
{
    double[,] newArray = new double[rows,columns];

    for(int i =0; i< rows;i++)
       for(int j =0;j <columns; j++)
           newArray[i,j] = new Random().Next(0,100) + new Random().NextDouble();

    return newArray;       
}

void Show2dArray(double[,] array)
{
    for(int i=0;i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
           Console.Write(array[i,j] + " ");
        Console.WriteLine();   
    }
}

Console.Write("Input number of rows M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns N: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] myArray = CreateRandom2dArray( m , n ); 
Show2dArray(myArray);

// 2.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//   и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] CreateRandom2dArray(int rows, int columns)
{
    int[,] newArray = new int[rows,columns];

    for(int i =0; i< rows;i++)
       for(int j =0;j <columns; j++)
           newArray[i,j] = new Random().Next(0 ,100);

    return newArray;       
}

void Show2dArray(int[,] array)
{
    for(int i=0;i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
           Console.Write(array[i,j] + " ");
        Console.WriteLine();   
    }
}

void ShowElement(int[,] array)
{
 Console.Write("Input first number: ");
 int m = Convert.ToInt32(Console.ReadLine());
 Console.Write("Input second number: ");
 int n = Convert.ToInt32(Console.ReadLine()); 

 for(int i=0;i<array.GetLength(0);i++)
     for(int j=0;j<array.GetLength(1);j++)
        if(i==m && j==n)  Console.WriteLine("This Element: " + array[m-1,n-1]);
        if(array.GetLength(0) < m || array.GetLength(1) < n) Console.WriteLine("There is no such number");
 }

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());


int[,] myArray = CreateRandom2dArray( m , n ); 
Show2dArray(myArray);
ShowElement(myArray);
*/
// 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

double[,] CreateRandom2dArray(int rows, int columns)
{
    double[,] newArray = new double[rows,columns];

    for(int i =0; i< rows;i++)
       for(int j =0;j <columns; j++)
           newArray[i,j] = new Random().Next(0,10);

    return newArray;       
}

void Show2dArray(double[,] array)
{
    for(int i=0;i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
           Console.Write(array[i,j] + " ");
        Console.WriteLine();   
    }
}

 void SumAveregeColumns(double[,] array)
 {
     double sum = 0;
     for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
    
        Console.WriteLine($" средее арифметическое  столбца {j + 1} равна {sum/array.GetLength(0)}");
        sum = 0;
     }
 }

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandom2dArray( m , n ); 
Show2dArray(myArray);
SumAveregeColumns(myArray);