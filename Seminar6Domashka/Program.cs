// 1. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int[] CreateArray(int size)
{
    int[] newArray = new int[size];
    Console.WriteLine("Введите числа: ");
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

int PositiveNumbers(int[]array)
{
    int count = 0;
    for(int i =0 ; i < array.Length ; i++)
        if(array[i] > 0) count ++;
    return count;
}

Console.WriteLine("Input M: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array1 = CreateArray(size);
ShowArray(array1);
int Positive = PositiveNumbers(array1);
Console.WriteLine($"Positive numbers: " + Positive);
