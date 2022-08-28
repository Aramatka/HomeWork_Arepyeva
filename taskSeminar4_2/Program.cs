/* 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */
int GetSumNumbers(int number)
{
int sum = 0;
if (number<0) {number = -number;}
    while (number>0)
    {   
    sum = sum + number%10;
    number = number / 10;    
    }
    return sum;
}
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());


System.Console.WriteLine($"Сумма чисел в числе {GetSumNumbers(num)}");