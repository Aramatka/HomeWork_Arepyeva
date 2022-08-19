/*Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27 
5 -> 1, 8, 27, 64, 125 */
Console.Write("Введите число: ");

int n = Convert.ToInt32(Console.ReadLine());
int number = 1;
while (number <= n)
{
// Console.WriteLine($"Куб от числа {number} = {Math.Pow(number,3)} ");
Console.Write($"{Math.Pow(number,3)}, ");

number++;
}