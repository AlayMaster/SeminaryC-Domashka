int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for(int i =0; i< size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}

int[] CreateArray(int size)
{
    int[] newArray = new int[size];
    Console.WriteLine("Creating array here: ");
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input {i+1} element: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    return newArray;
}

void ShowArray(int[] array)
{
   for(int i = 0; i < array.Length; i++)
       Console.Write(array[i] + " ");

   Console.WriteLine();    
}

//1.Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.

int ChetNumbers(int[] array)
{
    int count = 0;
    for( int i = 0; i < array.Length ;i++)
        if(array[i] % 2 == 0)  count++;  
    return count;
}

// 2.Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

int SumNechet(int[] array)
{
    int sum = 0;
    for( int i = 1; i < array.Length +1 ;i++)
        if(i % 2 == 0) sum = sum + array[i-1];
    return sum;
}   

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of elements: "); // Вводим 100 для первой задачи
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of elements: "); //Вводим  999 для первой задачи
int max = Convert.ToInt32(Console.ReadLine());

int[] array1 = CreateRandomArray(size, min, max);
ShowArray(array1);
Console.WriteLine($"Четных чисел: " + ChetNumbers(array1)); // Для первой задачи
Console.WriteLine($"Сумма элементов на нечетных позициях равна: " + SumNechet(array1)); //Для второй задачи


// 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double [] CreateRandomArray(int size, double minValue, double maxValue)
{
    double[] newArray = new double[size];
    for(int i =0; i< size; i++)
        newArray[i] = new Random().Next(0,100) + new Random().NextDouble();
    return newArray;
}
void ShowArray(double[] array)
{
   for(int i = 0; i < array.Length; i++)
       Console.Write(array[i] + " ");

   Console.WriteLine();    
}
double maxValue(double[] array) //Метод для поиска максимального элемента
{
    double max = array[0];
    for(int i = 1; i < array.Length;i++)
    {
        if(array[i] > max) max = array[i];
    }
    return max;
}

double minValue(double[] array) // Метод для поиска минимального элемента
{
    double min = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] < min) min = array[i];
    }
    return min;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of elements: ");
double min = Convert.ToDouble(Console.ReadLine());
Console.Write("Input max possible value of elements: "); 
double max = Convert.ToDouble(Console.ReadLine());

double[] array1 = CreateRandomArray(size, min, max);
ShowArray(array1);

double maxElement = maxValue(array1); // Ищем максимальный элемент
Console.WriteLine($"Max element: " + maxElement);

double minElement = minValue(array1);// Ищем минимальный элемент
Console.WriteLine($"Min element: " + minElement);

double DifferentElements = maxValue(array1)-minValue(array1); // Находим разность максимального и минимального элемента
Console.WriteLine($"Different max & min: " + DifferentElements);
