/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите номер дня недели от 1 до 7: ");
int number = int.Parse(Console.ReadLine() ??"");

if (number > 0 && number <8)
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine("Это выходной");
    }
    else
        Console.WriteLine("Это не выходной, а будний день");
}
else
    Console.WriteLine("Нет такого номера дня недели");