/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/
int[] GetArray(int size)
{
int[] massiv = new int[size];
for (int i = 0; i < massiv.Length; i++)
{
    System.Console.WriteLine("Введите элемент массива.");
massiv[i] = Convert.ToInt32(Console.ReadLine());
}
return massiv;
}
int[] array = GetArray(8);

Console.WriteLine($"Результат: [ {String.Join(", " ,array )} ]");