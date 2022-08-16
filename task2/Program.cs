// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

System.Console.WriteLine("Enter the first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter the second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter the third number: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());
int maxNumber = 0;
if (firstNumber > secondNumber)
{
    maxNumber = firstNumber;
}
else
{
    maxNumber = secondNumber;
}
maxNumber = Math.Max(maxNumber, thirdNumber);
System.Console.WriteLine("max = " + maxNumber);
