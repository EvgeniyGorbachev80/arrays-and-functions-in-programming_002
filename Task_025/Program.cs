// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Например:
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Exponentiation(int a, int b) // Функция возведения в степень
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    return result;
}
Console.Write("Введите число А: ");
int numberA = int.Parse(Console.ReadLine()!);

Console.Write("Введите число B: ");
int numberB = int.Parse(Console.ReadLine()!);

int result = Exponentiation(numberA, numberB);
Console.WriteLine("Число А в степени В, равно: " + result);
