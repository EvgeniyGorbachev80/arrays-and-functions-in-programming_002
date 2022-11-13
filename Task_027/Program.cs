// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11,
// 82 -> 10,
// 9012 -> 12.

int NumberLen(int a) // Функция подсчета цифр в числе
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}
void SumNumbers(int n, int len) // Функция вывода суммы цифр в числе
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine("Результат: " + sum);
}
Console.Write("Пожалуйста, введите число: ");
int number;
while (!int.TryParse(Console.ReadLine()!, out number) || number < 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Неверный ввод");
    Console.ResetColor();
    Console.Write("Пожалуйста, введите число: ");
}
int result = NumberLen(number);
SumNumbers(number, result);