/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */
System.Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int degree = 0;
int composition = 1;
if (numberB<0) {numberB = numberB *-1;}
while (degree < numberB)
{
    composition = composition*numberA;
    degree++;
}
System.Console.WriteLine(composition);