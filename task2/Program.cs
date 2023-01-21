// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

using static System.Console;

Console.Write("Введите любое число: ");

int num = Convert.ToInt32(Console.ReadLine());
string numStr = Convert.ToString(num);
int numDigit = numStr.Length;

if (numDigit > 2) WriteLine($"Третья цифра введённого числа: {numStr[2]}");
else WriteLine("третьей цифры нет");
