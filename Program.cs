﻿﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int firstDigit = number / 100; 
// int thirdDigit = number % 10; 
// int secondDigit = number - firstDigit*100 - thirdDigit;
// int result = secondDigit/10;
// Console.WriteLine($"{number} -> {result}");


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.Write("Введите число: ");
// string stringNumber = Console.ReadLine();
// int number; 
// bool isNumber = int.TryParse(stringNumber, out number);
// Console.WriteLine($"Длина строки(колличество символов): {stringNumber.Length}");
// if (isNumber && stringNumber.Length >= 3) 
// {
//     Console.WriteLine($"{stringNumber} => {stringNumber[2]}");
// }
// else
// {
//     Console.WriteLine("тут третьей цифры нет");
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.Write("Введите число N: ");
// int N= Convert.ToInt32(Console.ReadLine());
// if (N >7 )
// {
//  Console.WriteLine($"{N} -> такого дня недели не существует");
// }
//  else if (N == 7 || N == 6)
// {
//  Console.WriteLine($"{N} -> Ура! Выходной ");
// }
// else 
// {
//   Console.WriteLine($"{N} -> нет, это будни");
// }