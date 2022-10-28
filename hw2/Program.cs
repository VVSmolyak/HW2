// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.

//645 -> 5

//78 -> третьей цифры нет

//32679 -> 6

//1. Задать число
Console.WriteLine("Задать число: ");
int number = EnterNumber ();

//2. Определить есть ли 3-я цифра
while (number > 999)
    number = number / 10;

int number3 = number % 10;
    if (number >= 99)
    {
        Console.WriteLine("Третье число: " + number3);
    }
    else
    {
        Console.WriteLine("Третьего числа нет");
    }


int EnterNumber()
{
    int number = int.Parse(Console.ReadLine()!);
    return number;
}


