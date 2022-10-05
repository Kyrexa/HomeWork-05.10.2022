// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
Console.Write("Введите трёхзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i < 3 && (n <= 100 | n > 999); i++)
{
Console.Write(i + " Это не трёхзначное число! попробуем ещё раз: ");
n = Convert.ToInt32(Console.ReadLine());
}
n = n / 10 % 10;
Console.WriteLine($"Вторая цифра: {n}");