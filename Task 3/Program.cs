/* Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
 */
Console.Write("Введите число: ");
string istring = Console.ReadLine();
int lenght = istring.Length;

Console.WriteLine($"Длина строки = {lenght}");
int inum = int.Parse(istring);
int[] arr = new int[lenght - 1];
//int index = lenght - 1;
int index = 0;
while (inum > 0)
{
    arr[index] = inum % 10;
    Console.Write(arr[index]);
    inum = inum / 10;
    Console.WriteLine(inum);
    Console.WriteLine(arr[index]);
    //lenght = lenght - 1;
    //index = index - 1;
}
