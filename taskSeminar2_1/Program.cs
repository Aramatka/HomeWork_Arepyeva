/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Нужно сделать через числа, без индексов строк.
456 -> 5
782 -> 8
918 -> 1*/
System.Console.WriteLine("Введите трёхзначное число: ");
int Number = Convert.ToInt32(Console.ReadLine());
int secondDiv = (Number - (Number/100)*100)/10;
if (Number < 100 || Number > 999)
    {
    System.Console.WriteLine("Просила же, трёхзначное! Поробуйте ещё раз.");
    }
else System.Console.WriteLine($"У {Number} вторая цифра {secondDiv}.");