// Задача 69: Напишите программу, которая на вход принимает
// два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

Console.Write("Введите A: ");
bool isParsedA = int.TryParse(Console.ReadLine(), out int a);
Console.Write("Введите B: ");
bool isParsedB = int.TryParse(Console.ReadLine(), out int b);

if (!isParsedA || !isParsedB)
{
    Console.WriteLine("Ошибка!");
    return;
}

Console.WriteLine(Degree(a, b));

int Degree(int number, int degree)
{
    if (degree == 0)
    {
        return 1;
    }
    if (degree == 1)
    {
        return number;
    }
    degree--;
    return number * Degree(number, degree);
}