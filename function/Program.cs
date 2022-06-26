// void ShowNumber(){
//     int num = new Random().Next(10,100);
//     int firstNum = num/10;
//     int secondNum = num %10;
//     Console.Write(num + "->");
//     if(firstNum > secondNum){
//         Console.WriteLine(firstNum);
//     }
//     else{
//         Console.WriteLine(secondNum);
//     }
// }
// ShowNumber();


// int NumberWithoutSecDig(int Number){
//     int NewNumber = Number / 100 * 10 + Number % 10;
//     return NewNumber;
// }
// int Number = new Random().Next(100, 1000);
// int a = NumberWithoutSecDig(Number);
// Console.WriteLine(a + " " + Number);

// int Number1 = new Random().Next(11, 101);
// int Number2 = new Random().Next(1, 11);
// int result = 0;

// int MultipleNumber()
// {
//     result = Number1 % Number2;
//     return result;
// }

// MultipleNumber();


// if (result == 0) Console.WriteLine($"Число {Number1} кратно числу {Number2}");
// else
// {
//     Console.WriteLine($"Число {Number1} не кратно числу {Number2}, остаток от деления равен {Number1 % Number2}");
// }

// void NumDiv(int a, int b){
//     if(a == b*b){
//         Console.WriteLine(a + " квадрат " + b);
//     }else{
//         Console.WriteLine(a + " не квадрат " + b);
//     }
// }

// Console.WriteLine("Введите два числа: ");
// NumDiv(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));

// void getDot(int x, int y){
//     if(x == 0 || y == 0){
//         Console.WriteLine("Нет возможности определить четверть");
//     }
//     else{
//         if(x > 0 && y > 0)
//             Console.WriteLine("1 четверть");
//             if(x > 0 && y < 0)
//             Console.WriteLine("4 четверть");
//                 if(x < 0 && y > 0)
//                 Console.WriteLine("2 четверть");
//                     if(x > 0 && y < 0)
//                     Console.WriteLine("3 четверть");
//     }
// }
// Console.WriteLine("Введите две точки");
// int x1 = Convert.ToInt32(Console.ReadLine());
// int y1 = Convert.ToInt32(Console.ReadLine());

// getDot(x1,y1);

// Еще задание

// void getDot(int num){
//     if(num == 1){
//             Console.WriteLine("x > 0,y > 0");
//     }
//     else if(num == 2)
//             Console.WriteLine("x < 0, y > 0");
//     else if(num == 3)
//             Console.WriteLine("x < 0, y < 0");
//     else if(num == 4)
//             Console.WriteLine("x > 0, y < 0");
//     else
//             Console.WriteLine("Введено некоректное число");
// }
// Console.WriteLine("Введите номер четверти");
// int a = Convert.ToInt32(Console.ReadLine());
// getDot(a);

// Еще задание
// double distAB(int x1, int y1, int x2, int y2){
//     return Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2));
// }
// Console.WriteLine("Введите координаты x1: ");
// int xA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты y1: ");
// int yA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты x2: ");
// int xB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты y2: ");
// int yB = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Длина отрезка " + distAB(xA, yA, xB, yB));

Console.Clear();


// void listSqrt(int n){
//         int count = 1;

//         Console.Write(n + "->");

//         if(n > 0){

//         while(count <= n){
//         Console.Write(Math.Pow(count, 2) + ", ")  ;
//         count++;
//         }
//         }else
//         {
//             count = -1;
//             while(count >= n){
//             Console.Write(Math.Pow(count, 2) + ", ")  ;
//             count--;
//         }
//     }

// }

// Console.WriteLine("Введите любое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// listSqrt(a);

// int sumToNum(int num)
// {
//     int sum = 0;
//     for(int i = 1; i <= num; i++)
//     {
//         sum += i;
//     }
//     return sum;
// }
// Console.WriteLine("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Sum of elements is " + sumToNum(number));

// Console.WriteLine("Введите любое число");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// while(number > 0){
//     number= number / 10;
//     count++;
// }
// Console.WriteLine(count);

// int ToNum(int num){

//     int multiple = 1;
//     for(int i= 1; i <= num; i++)
//     {
//         multiple *=i;
//     }
//     return multiple;
// }
// Console.WriteLine("Введите любое число");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(ToNum(number));


// int[] CreateRandomArray(int size)
// {
//     int[] array = new int [size];
//         for(int i= 0; i < size; i++){
//             array[i] = new Random().Next(0,2);
//         }
//         return(array);
// }
// int[] CreateArray(int size){
//     int[] array = new int [size];
//     for(int i= 0; i < size; i++){
//         Console.Write("Input" + i + "element: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return(array);
// }


// void ShowArray(int[] array)
// {
//     for(int i = 0;i < array.Length; i++){;
//         Console.Write(array[i] + " ");
//     }
// }
// int [] myRandomArray = CreateRandomArray(8);
// ShowArray(myRandomArray);
// Console.WriteLine();
// int[] myArray = CreateArray(8);


// ShowArray(myArray);

// string name = "Имя";
// int age = 99;
 
// Console.WriteLine($"Имя: {name, -10.CompareTo/*Кол-во пробелов*/} Возраст: {age}"); // пробелы после
// Console.WriteLine($"Имя: {name, 15} Возраст: {age}"); // пробелы до


// int[] CreateRandomArray(int size, int min, int max){
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++){
//         array[i] = new Random().Next(min,max+1);
//     }
//     return array;
// }
// void ShowArray (int[] array){

//     for (int i = 0; i < array.Length; i++){
//         Console.Write(array[i] + " ");
//     }
// }

// int[] MyArray = CreateRandomArray(12,-9, 9);
// ShowArray(MyArray);

// int sum_pos = 0;
// int sum_neg = 0;
// for (int i = 0; i < MyArray.Length; i++)
// {
//     if(MyArray[i] > 0)
//         sum_pos += MyArray[i];
//     else
//         sum_neg += MyArray[i];
// }
// Console.WriteLine($"Сумма положительных: {sum_pos}. Сумма отрицальных {sum_neg}");

// int[] CreateRandomArray(int size){
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++){
//         array[i] = new Random().Next(-100,101);
//     }
//     return array;
// }
// int[] GetArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         /*array[i] = array[i] * (-1);*/
//         array[i]*=-1;
//     }
//     return array;
// }
// void ShowArray (int[] array){

//     for (int i = 0; i < array.Length; i++){
//         Console.Write(array[i] + " ");
//     }
// }
// int[] array =CreateRandomArray(3);
// ShowArray(array);
// Console.WriteLine();
// ShowArray(GetArray(array));

int Number = 25;
int size = 15;
int min = 1;
int max = 50;

int[] CreateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

bool FindNumber(int[] array, int Number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == Number) return true;
    }
    return false;
}

void PrinArray(int[] arr)
{
    System.Console.WriteLine();
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
    System.Console.WriteLine();
}

int[] array = CreateArray(size, min, max);
PrinArray(array);
if (FindNumber(array, Number)){
    Console.WriteLine($"Число {Number} присутствует в массиве");
    }
else {
    Console.WriteLine($"Число {Number} отсутсвует в массиве");
    }
Console.WriteLine();
