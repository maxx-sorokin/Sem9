// Задача 65: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.

Console.Write("Введите M: ");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите N: ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

if (!isParsedM || !isParsedN)
{
    Console.WriteLine("Ошибка!");
    return;
}

PrintNumbers(n, m);

void PrintNumbers(int n, int i = 1)
{
    if (i > n)
    {
        return;
    }
    Console.Write($"{i} ");
    PrintNumbers(n, i + 1);
}