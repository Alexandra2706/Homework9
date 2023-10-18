// Задайте значения M и N. Напишите прграмму, 
// которая найдет сумму натуральных элементов в промежутке от M до N
// M = 1, N = 15 -> 120
// M = 4, N = 8 -> 30

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

int Subsequence(int numM, int numN)
{
    if (numM == numN) return numM;
    else return numM + Subsequence(numM + 1, numN);
}


int numberM = EnterParam("Введите значение M: ");
int numberN = EnterParam("Введите значение N: ");
if (numberM > numberN)
{
    int temp = numberM;
    numberM = numberN;
    numberN = temp;
}
Console.WriteLine($"Сумма чисел от {numberM} до {numberN}  равна {Subsequence(numberM, numberN)}");