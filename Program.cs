﻿// Задача 1: 
// Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа. 
// Обязательна проверка на ввод чисел больше/меньше 3-х знаков.

Console.WriteLine("Введите трехзначное число");
int num1 = int.Parse(Console.ReadLine()!);
int num3 = num1;
int i = 0;
while (num1 != 0)
{
    num1 /= 10;
    i++;
}

// Console.WriteLine($"Ваше число имеет {i} разрядов");

if (i == 3)
{
int num2 = (num3/10)%10;
Console.WriteLine($"Втораяцифра вашего числа {num2}.");
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число!");
}

// Задача 2:
// Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
// Берем числа до 100000.


// Задача 3:
// Напишите программу, которая принимает на вход цифру, обозначающую
// день недели, и проверяет, является ли этот день выходным.
// Обязательна проверка на ввод числа <1 и >7.