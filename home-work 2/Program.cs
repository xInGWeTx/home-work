﻿// Задание 1(Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.)
int number = new Random().Next(124, 999);
Console.Write("Второй цифрой числа: " + number + " , является: ");
Console.WriteLine(number /10 % 10);

// Задание 2(Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.)

int num = new Random().Next(1, 250);
if(num/100 >0){
    Console.Write("Третьей цифрой числа: " + num + " , является: ");
    Console.WriteLine(num/100 %10);/*(либо num/100 %10 смотря с какой стороны считать 3 цифру)*/
}
else{
    Console.WriteLine("У числа: " + num + " нет третьей цифры");
}

// Задание 3(Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.)

int weekend = new Random().Next(1, 8);
string[] Days= { "Понедельник", "Вторник", "Среда", "Четверг","Пятница","Суббота","Воскресенье"};
if(weekend > 5){
    Console.WriteLine(weekend + "-й день недели." + " Это выходной день!");
}
else{
    Console.WriteLine(weekend + "-й день недели." + "Это рабочий день!");
}