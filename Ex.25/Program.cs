// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetNaturalDegree(int a, int b)
{   
    int naturalDegree = 1;
    int count = 0;
    while (count < b)
    {
        naturalDegree = naturalDegree * a;
        count ++;
    }
    return naturalDegree;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int a = GetInput("Введите число A: ");
int b = GetInput("Введите число B: ");
Console.WriteLine($"Число {a} в степени {b} равно {GetNaturalDegree(a, b)}");
