/*  Задача 4: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да 
7 -> да 
1 -> нет
 */
Console.Write("Введите порядковый номер дня недели: ");
string istring = Console.ReadLine();
int inum = int.Parse(istring);
if (inum < 1 || inum > 7)
{
    Console.WriteLine("Такого порядкового номера дня недели не существует");
}
else if (inum == 6 || inum == 7)
{
    Console.WriteLine("Этот день выходной");
}
else
{
    Console.WriteLine("Этот день будний");
}