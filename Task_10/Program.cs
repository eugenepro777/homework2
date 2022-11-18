//Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру
// этого числа.
Console.WriteLine("Введите трехзначное число:");

int numIn = Convert.ToInt32(Console.ReadLine());

if (numIn < 100 || numIn >= 1000)
{
    Console.WriteLine("Число не трёхзначное");
}
else
{
    int numOut = (numIn % 100 - numIn % 10) / 10;
    Console.WriteLine($"Вторая цифра: {numOut}");
}