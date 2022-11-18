/* Напишите программу, которая принимает на вход цифру,
 обозначающую день недели, и проверяет, 
 является ли этот день выходным.
 */

Console.WriteLine("Введите порядковый номер дня недели: ");

int numberDay = Convert.ToInt32(Console.ReadLine());

if (numberDay == 6 || numberDay == 7)
{
    Console.WriteLine("Выходной день");
}
else if (numberDay < 1 || numberDay > 7)
{
    Console.WriteLine("За границами недели");
}    
else
{
    Console.WriteLine("Рабочий день");
}