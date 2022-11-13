/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите первое число: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите первое число: ");
int B = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int C = int.Parse(Console.ReadLine());

if (A > B && A > C)
    Console.WriteLine($"максимальное число = {A}.");
if (B > A && B > C)
Console.WriteLine($"максимальное число = {B}.");
else 
Console.WriteLine($"максимальное число = {C}.");