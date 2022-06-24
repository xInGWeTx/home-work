// Console.Clear();
// Console.WriteLine("Введите любое пятизначное число");
// string number =Console.ReadLine();
// int length = number.Length;
// bool IsPalindrome()
// {
//     for (int i = 0; i < length / 2; i++)
//         while (number[i] == number[length - 1])
//         {
//             return true;
//         }
//     return false;
// }
// if (IsPalindrome()){
//     Console.WriteLine($"1. Введенное число - {number} - является палиндромом");
//     }
// else {
//     Console.WriteLine($"1. Число {number} не является палиндромом");
//     }

// Второе задание(Расстояние = $ \ sqrt {(x2-x1) ^{2} + (y2-y1) ^{2} + (z2-z1) ^{2}} $ )Делал по этой формуле

// double distAB(int x1, int y1, int z1, int x2, int y2, int z2){
//     return Math.Sqrt(Math.Pow(x2 - x1, 2)
//                     + Math.Pow(y2 - y1, 2)
//                     + Math.Pow(z2 - z1, 2));
// }
    

// Console.WriteLine("Введите координаты x1: ");
// int xA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты y1: ");
// int yA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты z1: ");
// int zA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты x2: ");
// int xB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты y2: ");
// int yB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты z2: ");
// int zB = Convert.ToInt32(Console.ReadLine());


// Console.WriteLine("Длина отрезка " + distAB(xA, yA,zA, xB, yB, zB));

// Третье задание


void listSqrt(int n){
        int count = 1;
        
        Console.Write(n + "->");
    
        if(n > 0){
        
        while(count <= n){
        Console.Write(Math.Pow(count, 3) + ", ")  ;
        count++;
        }
        }else
        {
            count = -1;
            while(count >= n){
            Console.Write(Math.Pow(count, 3) + ", ")  ;
            count--;
        }
    }
    
}

Console.WriteLine("Введите любое число: ");
int a = Convert.ToInt32(Console.ReadLine());
listSqrt(a);
