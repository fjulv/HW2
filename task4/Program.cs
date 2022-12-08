// Задача 4: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, 
// является ли этот день выходным. 
// Не использовать строки

// 6 -> да
// 7 -> да
// 1 -> нет

int Prompt(string message)
{
    System.Console.WriteLine($"{message} ");
    int Day = Convert.ToInt32(Console.ReadLine());
    return Day;
}

int day = Prompt("Введи цифру, обозначающую день недели ");

if (day > 0 && day <= 7)
{
    if (day < 6)
    {
        Console.WriteLine("День " + day + " не является выходным днем недели");
    }
    else
        Console.WriteLine("Ура, день " + day + " - выходной день!");
}

else
{
    Console.WriteLine("День " + day + " не является днем недели (введи цифру от 1 до 7)");
}