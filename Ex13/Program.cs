﻿// Задача 13: Напишите программу, которая выводит
//третью цифру заданного числа или сообщает, что третьей
//цифры нет.
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
if (num < 100)
{ 
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while (num > 1000)
    {
        num = num / 10;
    }
    Console.WriteLine(num % 10);
}
