// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
System.Console.WriteLine("Enter a number to check: ");
int Number = Convert.ToInt32(Console.ReadLine());
if ((Number % 2) == 0)
{
    System.Console.WriteLine(Number + " четное");
}
else
{
        System.Console.WriteLine(Number + " нечетное");
}