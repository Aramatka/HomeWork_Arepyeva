// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

System.Console.WriteLine("Enter the first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter the second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber > secondNumber)
{
    System.Console.WriteLine("max=" + firstNumber);
}
else
{
       System.Console.WriteLine("max=" + secondNumber); 
}