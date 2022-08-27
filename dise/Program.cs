// Бросок дайса
System.Console.WriteLine("Введите стоимость дайса: ");

int dise = Convert.ToInt32(Console.ReadLine());

int num = new Random().Next(1, dise+1);
System.Console.WriteLine($"На кубике выпало {num}");
