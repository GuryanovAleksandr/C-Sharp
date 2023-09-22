// Написать программу, которая на вход принимает число и выдает его квадрат
// (число умноженное на само себя)

// Например:
// 4 -> 16
// -3 -> 9 

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
Console.Write("Квадрат числа = "); // Console.WriteLine("Квадрат числа = " + number * number);
Console.WriteLine(number * number); // <<<=== эта строка не нужна, если написать так ^^^
