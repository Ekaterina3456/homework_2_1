﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Ведите первое число");
int num1 = Convert.ToInt32( Console.ReadLine());
Console.WriteLine("Ведите второе число");
int num2 = Convert.ToInt32( Console.ReadLine());
Console.WriteLine("Ведите третье число");
int num3 = Convert.ToInt32( Console.ReadLine());


if (num1>num2 & num1 > num3)
    Console.WriteLine("первое число больше");
else if (num2 > num1 & num2 >num3)
    Console.WriteLine("второе число больше");
else 
    Console.WriteLine("третье число больше");