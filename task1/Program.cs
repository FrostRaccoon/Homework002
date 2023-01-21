// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8 
// 918 -> 1

using static System.Console;

WriteLine("Введите трёхзначное число ");
int num = Convert.ToInt32(ReadLine());

int result = ((num / 10) % 10);
WriteLine($"{num} -> {result}");