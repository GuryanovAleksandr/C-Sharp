// Задача №1.
// Напишите программу, которая на вход принимает два числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да

Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine()!);
if (a == (b * b))
{
    Console.WriteLine("Число а квадрат числа b");
}   
else
{
     Console.WriteLine("Число а не квадрат числа b");
}