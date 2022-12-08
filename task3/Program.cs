// Задача 3: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, 
// что третьей цифры нет. 
// Не использовать строки
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Prompt(string message)
{
    System.Console.WriteLine($"{message} ");
    int Number = Convert.ToInt32(Console.ReadLine());
    return Number;
}

int num = Prompt("Введи целое число ");

while (num >= 1000)
{
    num = num/10;
}
if (num > 99)
{
    Console.WriteLine("Третья цифра числа " + num % 10);
}
else
    Console.WriteLine("Третьей цифры нет");

