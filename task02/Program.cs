﻿/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введите первое число: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите первое число: ");
int B = int.Parse(Console.ReadLine());

if (A > B)
    Console.WriteLine($"максимальное число = {A}.");
else
    Console.WriteLine($"максимальное число = {B}.");