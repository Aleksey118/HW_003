// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

void PalindromeChecker(int numbers)
{
    int tempNum1 = numbers % 100;
    int tempNum2 = numbers / 1000;
    if (tempNum1 % 10 == tempNum2 / 10 && tempNum2 % 10 == tempNum1 / 10)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }

}

int GetNum(string text)
{
    Console.WriteLine(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int numbers = GetNum("Введите число");
Console.Write(numbers + " -> ");

PalindromeChecker(numbers);