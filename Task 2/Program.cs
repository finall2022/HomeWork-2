/*  Задача 2: Напишите программу, которая выводит случайное трёхзначное число
 и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
 */

Random rnd = new Random();
int number = rnd.Next(100, 1000);
Console.WriteLine($"Случайное число: {number}");
int n1 = number / 100;
int n2 = number % 100 / 10;
int n3 = number % 10;
Console.Write($"Число после удаления второй цифры: {n1}{n3}");