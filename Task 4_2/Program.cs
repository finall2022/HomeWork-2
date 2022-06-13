/*  Задача 4: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да 
7 -> да 
1 -> нет
 */
string numofday(int num)
{
    if (num > 0 && num < 7)
    {
        //string result = "будний";
        Console.Write("будний");
    }
    else
    {
        //string result = "выходной";
        Console.Write("выходной");
    }
    //return result;
}

Console.Write("Введите порядковый номер дня недели: ");
string istring = Console.ReadLine();
int inum = int.Parse(istring);
numofday(inum);
