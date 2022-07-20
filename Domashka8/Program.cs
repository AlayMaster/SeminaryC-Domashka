// Задача1. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
//          элементы каждой строки двумерного массива.
/*
int[,] CreateRandom2dArray(int rows, int columns)
{
    int[,] newArray = new int[rows,columns];

    for(int i =0; i< rows;i++)
       for(int j =0;j <columns; j++)
           newArray[i,j] = new Random().Next(0,100);

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

int[,] OrderedArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) ; j++)
        {
            int maxJ = j;
            {
                for (int k = j ; k < array.GetLength(1); k++)
                {
                    if (array[i, k] > array[i, maxJ]) maxJ = k;   
                }
                int temp = array[i, j];
                array[i, j] = array[i, maxJ];
                array[i, maxJ] = temp;
            }

        }
    }
    return array;
    
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray( m , n ); 
Show2dArray(myArray);
Console.WriteLine();
Show2dArray(OrderedArray(myArray));
*/
// Задача 2.  Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
//            находить строку с наименьшей суммой элементов.
/*
int[,] CreateRandom2dArray(int rows, int columns)
{
    int[,] newArray = new int[rows,columns];

    for(int i =0; i< rows;i++)
       for(int j =0;j <columns; j++)
           newArray[i,j] = new Random().Next(0,10);

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

int MinSumRow(int[,] array)
{
    int minSum = 0;
    int minI = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if(minSum > sum || i==0)
        {
            minSum = sum;
            minI = i;
        }
    }
    Console.WriteLine($"Cтрокa с наименьшей суммой ({minSum}) элементов - {minI+1} ");
    return minI;
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray( m , n ); 
Show2dArray(myArray);
Console.WriteLine();
MinSumRow(myArray);
*/

// Задача3. Заполните спирально массив 4 на 4.

int[,] CreateRandom2dArray(int rows, int columns)
{
    int[,] newArray = new int[rows,columns];

    for(int i =0; i< rows;i++)
       for(int j =0;j <columns; j++)
           newArray[i,j] = new Random().Next(0,100);

    return newArray;       
}

int[,] Spiral(int[,] array)
{
    int count = 0;
    int i = 0;
    int j = 0;
    for (j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = count + 1;
        count++;
    }

    j = array.GetLength(1) - 1;

    for (i = 1; i <array.GetLength(0); i++)
    {
        array[i, j] = count + 1;
        count++;
    }

    i = array.GetLength(0) - 1;

    for (j = array.GetLength(1) - 2; j >= 0; j--)
    {
        array[i, j] = count + 1;
        count++;
    }

    j = 0;

    for (i = array.GetLength(0) - 2; i > 0; i--)
    {
    array[i, j] = count + 1;
    count++;
    }

    i = 1;

    for (j = 1; j < array.GetLength(1) - 1; j++)
    {
    array[i, j] = count + 1;
    count++;
    }   

    i = 2;

    for (j = 2; j > 0; j--)
    {
        array[i, j] = count + 1;
        count++;
    }

    return array;

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

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray( m , n ); 
Show2dArray(Spiral(myArray));

