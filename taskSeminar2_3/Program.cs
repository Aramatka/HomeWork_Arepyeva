/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/
System.Console.WriteLine("Введите цифру от 1 до 7: ");
int Number = Convert.ToInt32(Console.ReadLine());
if ( Number > 7)
    {
    System.Console.WriteLine($"Цифра {Number} не определяет день недели.");
    }
else
{
    if (Number == Next(1, 6))
    {
        System.Console.WriteLine("да");
    }
    if (Number==6 || Number == 7)
    {
        System.Console.WriteLine("да");
    }
}