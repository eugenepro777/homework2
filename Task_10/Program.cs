//Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру
// этого числа.
Console.WriteLine("Введите трехзначное число:");

int numIn = Convert.ToInt32(Console.ReadLine());
int numOut = (numIn % 100 - numIn % 10) / 10;

if (numIn < 100 || numIn >= 1000)
{
    Console.WriteLine("Число не трёхзначное");
}
else
{
    Console.WriteLine($"Вторая цифра: {numOut}");
}