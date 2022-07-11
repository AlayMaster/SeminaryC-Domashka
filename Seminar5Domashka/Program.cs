int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for(int i =0; i< size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}
/*
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
*/
void ShowArray(int[] array)
{
   for(int i = 0; i < array.Length; i++)
       Console.Write(array[i] + " ");

   Console.WriteLine();    
}

//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
/*
int ChetNumbers(int[] array)
{
    int count = 0;
    for( int i = 0; i < array.Length ;i++)
        if(array[i] % 2 == 0)  count++;  
    return count;

}
*/
// Задайте одномерный массив, заполненный случайными числами.
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
Console.Write("Input min possible value of elements: "); // Вводим 100
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of elements: "); //Вводим  999
int max = Convert.ToInt32(Console.ReadLine());

int[] array1 = CreateRandomArray(size, min, max);
ShowArray(array1);
//Console.WriteLine($"Четных чисел: " + ChetNumbers(array1));
Console.WriteLine($"Сумма нечетных чисел равна: " + SumNechet(array1));





