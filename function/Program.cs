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

void NumDiv(int a, int b){
    if(a == b*b){
        Console.WriteLine(a + " квадрат " + b);
    }else{
        Console.WriteLine(a + " не квадрат " + b);
    }
}

Console.WriteLine("Введите два числа: ");
NumDiv(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));



