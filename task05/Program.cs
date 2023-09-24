// Задача №7. 
// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите трехзначное число: ");                // через string:
int num = int.Parse(Console.ReadLine()!);                        // string number = Console.ReadLine();
if (num > 99 && num < 1000)                                      // int len = number.Length;
{                                                                // if (len == 3)
    int last = (num % 10);                                       // {
    Console.WriteLine("Последняя цифра данного числа: " + last); //     Console.WriteLine(number[2]);    
}                                                                // } 
else                                                             // else
Console.WriteLine("Это не трехзначное число!");                  // {
                                                                 //     Console.WriteLine("Это не трехзначное число!");
                                                                 // }  