// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

Console.Write("Введите число: ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

if (!isParsedN)
{
    Console.WriteLine("Ошибка!");
    return;
}

Console.WriteLine(SumDigits2(n));

int SumDigits(int number, int sum = 0)
{
    sum += number % 10;
    number /= 10;
    if (number > 0)
    {
        sum = SumDigits(number, sum);
    }
    return sum;
}

int SumDigits2(int number)
{
    Console.WriteLine($"{number % 10} цифра - {number} число");
    if (number == 0)
    {
        return 0;
    }
    return number % 10 + SumDigits2(number / 10);
}