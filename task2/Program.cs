// Задача 2: Напишите программу,
// которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа. 
// Не использовать строки для расчета

// 456 -> 46
// 782 -> 72
// 918 -> 98

int Number = new Random().Next(100, 1000);

Console.WriteLine("Наше случайное число = " + Number);

int num1 = Number / 100 % 10;
int num2 = Number / 10 % 10;
int num3 = Number % 10;

int Result = num1 * 10 + num3;

Console.WriteLine("Искомое число = " + Result);