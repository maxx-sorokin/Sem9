// Задача 63: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от 1 до N.

Console.Write("Введите N: ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

if (!isParsedN)
{
    Console.WriteLine("Ошибка!");
    return;
}
PrintNumbers(n);

void PrintNumbers(int n, int i = 1)
{
    if (i > n)
    {
        return;
    }
    Console.Write($"{i} ");
    PrintNumbers(n, i + 1);
}