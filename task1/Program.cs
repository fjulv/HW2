// Задача 1: Напишите программу, 
// которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. 
// Не использовать строки

// 456 -> 5
// 782 -> 8
// 918 -> 1

int Prompt(string message)
{
    System.Console.WriteLine($"{message} ");
    int Number = Convert.ToInt32(Console.ReadLine());
    return Number;
}

int num = Prompt("Введи трехзначное число ");

if (num >= 100 && num <= 999)
{
    Console.WriteLine("Вторая цифра указанного числа - " + (num % 100) / 10);
}
else
    Console.WriteLine("Будь внимательнее, введено не трехзначное число");