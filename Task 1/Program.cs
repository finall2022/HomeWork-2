/* Задача 1: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

Console.Write("Введите трехзначное число: ");
string istring = Console.ReadLine();
int inum = int.Parse(istring);
int lenght = istring.Length;
if (lenght != 3)
{
    Console.WriteLine("Число не трёхзначное!");
}
else
{
    int n2 = inum / 10 % 10;
    Console.Write($"Вторая цифра числа {inum} - {n2}");
}
