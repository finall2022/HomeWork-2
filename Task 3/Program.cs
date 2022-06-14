/* Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
 */
Console.Write("Введите число: ");
string istring = Console.ReadLine();
int lenght = istring.Length;

//Console.WriteLine($"Длина строки = {lenght}");
int index = lenght - 1;
int inum = int.Parse(istring);
int[] arr = new int[lenght];
if (lenght < 3)
{
    Console.WriteLine($"Третьей цифры не существует, число {inum} - двузначное");
}
else if (lenght > 2)
{
    while (index > 0 || index == 0)
    {
        arr[index] = inum % 10;
        inum = inum / 10;
        index = index - 1;
    }
    Console.WriteLine($"Третья цифра = {arr[2]}");
}

