// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetSum(int digit)
{
    int lastDigit = digit % 10;
    int sum = lastDigit;
    while ( digit > 0)
    {
        digit = digit / 10;
        sum = sum + digit % 10;
    }
    return sum;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int n = GetInput("Введите число N: ");
Console.WriteLine($"Сумма цифр в числе {n} равна {GetSum(n)}");