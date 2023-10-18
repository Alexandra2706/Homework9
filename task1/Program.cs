// Задайте значение N. Напишите программу, которая выведелт все натуральные числа в промежутке
// от N до 1. Выполнить с помощью рекурскии
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int EnterParam(string msg)
{
    Console.Write(msg);
    if (!int.TryParse(Console.ReadLine(), out var number))
    {
        Console.WriteLine("Ошибка ввода");
        Environment.Exit(0);
    }
    return number;
}

void Subsequence(int num)
{
    if (num == 1) Console.Write(num);
    else
    {
        Console.Write($"{num}, ");
        Subsequence(num - 1);
    }
}


int number = EnterParam("Введите натуральное значение N: ");
if (number == 0)
{
    Console.WriteLine("0 - не натуральное число");
    Environment.Exit(0);
}
Subsequence(Math.Abs(number));