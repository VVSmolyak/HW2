//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine ("Введите цифру: ");
int number = int.Parse (Console.ReadLine ()!);

if (checkweekends (number)) {
    Console.WriteLine ("да");
}
else {
    Console.WriteLine ("нет");
}

bool checkweekends (int number)
{
    return number == 6 || number == 7;
}