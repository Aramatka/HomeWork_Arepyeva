// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

System.Console.WriteLine("Enter a number: ");
int Number = Convert.ToInt32(Console.ReadLine());
int evenNumber = 2;
while (evenNumber < Number)
{
    System.Console.Write(evenNumber + ", ");
    evenNumber +=2;
}