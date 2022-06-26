// 1 задание Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();

// int[] CreateRandomArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
//     return array;
// }

// void PrintResult(int[] array)
// {
//     int even = 0;
//     int uneven = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//         if (array[i] % 2 == 0) even++;
        
//     }
//     
//     Console.WriteLine($"Количество четных чисел {even}");
//     
// }
// int[] array= CreateRandomArray(4);
// PrintResult(array);

// 2 задание (Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.)
// int size = 5;
// int[] CreateRandomArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(1, 100);
//     }
//     return array;
// }

// void PrintArray(int[] arr)
// {
//     int sum = 0;
//     System.Console.WriteLine();
//     for (int i = 0; i < size; i++)
//     {
//         Console.Write(arr[i] + " ");
//         if (i % 2 > 0) sum += arr[i];
//     }
    
//     Console.WriteLine($"Сумма чисел, стоящих на нечетной позиции, соcтаваляет {sum} ");
    
// }

// PrintArray(CreateRandomArray(size));

// 3 задание (Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.)

int size = new Random().Next(4, 15);

Console.WriteLine($"Количетсов элементов массива: {size}");

int[] CreateRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(10,2000);
    }
    return array;
}

void PrintMinMax(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
    int difference = array.Max() - array.Min();
    Console.WriteLine($"Максимальное значение массива {array.Max()}, минимальное значение массива {array.Min()}");
    Console.WriteLine($"Разница между минимальным и максимальным значениями массива составляет {difference}");
}

PrintMinMax(CreateRandomArray(size));


