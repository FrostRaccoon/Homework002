// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");

int num = Convert.ToInt32(Console.ReadLine());

while (num >= 1000)
{
    num /= 10;
}

Console.WriteLine(num % 10);
