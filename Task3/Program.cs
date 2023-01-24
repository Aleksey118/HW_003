// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void RowDigits(int n)
{
    for (int i = 1; i < n; i++)
    {
        Console.Write(Math.Pow(i, 3) + ", ");
    }
    Console.Write(Math.Pow(n, 3) + ". ");
}

int GetNum(string text)
{
    Console.WriteLine(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int n = GetNum("Введите значение N");

Console.Write(n + " -> ");
RowDigits(n);