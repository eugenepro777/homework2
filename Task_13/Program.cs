// Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.

int numIn = new Random().Next();
int numberThird = 0;
Console.WriteLine($"Число на входе: {numIn}");

if (numIn >= 100)
{
    while (numIn > 999)
    {
        numIn = numIn / 10;
    }
    numberThird = numIn % 10;
}
if (numberThird < 0)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.Write($"Третья цифра: {numberThird}");
}