// 1 задание Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if(num1>num2){
//     Console.WriteLine("Наибольшее число {0} ", num1);
//     Console.WriteLine("Наименьщее число {0} ", num2);
// }
// else{
//     Console.WriteLine("Наибольшее число {0} ", num2);
//     Console.WriteLine("Наименьщее число {0} ", num1);
// }

// 2 задание(Не разрешает одинаковые названия num(буду использовать буквы))Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.WriteLine("Введите первое число");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите третье число");
// int c = Convert.ToInt32(Console.ReadLine());

// int max =a;
// if(a>max) max=a;
// if(b>max) max=b;
// if(c>max) max=c;

// Console.Write("max = ");
// Console.WriteLine(max);

// 3 задание Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// Console.WriteLine("Введите число");
// int a = Convert.ToInt32(Console.ReadLine());

// if(a % 2 == 0){
//     Console.WriteLine("Четное число");
    
    
// }
// else{
//     Console.WriteLine("Нечетное число ");

// }

// 4 задание Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int result= 1;
while(result < a){
    Console.WriteLine(result+1);
    result+=2;
}