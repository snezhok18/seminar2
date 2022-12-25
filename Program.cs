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

int num21 = new Random().Next(100000);

Console.WriteLine($"Введено число {num21}");

int num22 = num21;
int count = 0;
while (num21 != 0)
{
    num21 /= 10;
    count++;
}

//Console.WriteLine($"В числе {count} разрядов.");

if (count < 3)
{
    Console.WriteLine($"В числе {num22} нет третьей цифры");
}
if (count == 3)
    {
        int num23 = num22%10;
        Console.WriteLine($"Третья цифра вашего числа {num23}.");
    }
if (count == 4)
    {
        int num23 = (num22/10)%10;
        Console.WriteLine($"Третья цифра вашего числа {num23}.");
    }    

if (count == 5)
    {
        int num23 = (num22/100)%10;
        Console.WriteLine($"Третья цифра вашего числа {num23}.");
    }    

// Задача 3:
// Напишите программу, которая принимает на вход цифру, обозначающую
// день недели, и проверяет, является ли этот день выходным.
// Обязательна проверка на ввод числа <1 и >7.

Console.WriteLine("Введите ЦИФРОЙ нужный день недели.");
int num = int.Parse(Console.ReadLine()!);
if (num < 1 || num > 7)
{
    Console.WriteLine("Введите число от 1 до 7");
}
if (num < 6 && num > 1)
{
    Console.WriteLine("Ещё чуть-чуть поработайте! )");
}
if (num > 5 && num < 8)
{
    Console.Write("Расслабьтесь! Сегодня выходной.");
}
