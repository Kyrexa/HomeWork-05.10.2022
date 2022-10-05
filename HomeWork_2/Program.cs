//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите любое число: ");
int n = Convert.ToInt32(Console.ReadLine());
string nStr = Convert.ToString(n);
int n1 = nStr.Length;
if (n1 > 2) 
Console.WriteLine($"Третья цифра введённого числа: {nStr[2]}");
else 
Console.WriteLine("третьей цифры нет");