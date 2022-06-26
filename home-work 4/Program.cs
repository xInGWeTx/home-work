// 1 задание (Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.)

// Console.WriteLine("Введите число");
// int A =Convert.ToInt32(Console.ReadLine());

// int count = 1;
// int exponent = 10;
// int result = A;
// while(count < exponent){
//     result = result * A;
//     count++;
// }
// System.Console.WriteLine($"{A} ^ {exponent} = {result}");
// System.Console.WriteLine();

// 2 задание(Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.)

// int number = new Random().Next(10, 100000);
// int sumDigit = 0;
// Console.Write($"Сумма цифр числа {number} равна ");

// while (number > 0)
// {
//     int digit = number % 10;
//     sumDigit = sumDigit + digit;
//     number = number / 10;
// }

// Console.WriteLine(sumDigit);
// Console.WriteLine();

// 3 задание (Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.)

int[] CreateRandomArray(int x)
{
    int[] arr = new int[x];
    for (int i = 0; i < x; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        System.Console.Write($"{array[i]} ");
}
int[] array = CreateRandomArray(3);
PrintArray(array);