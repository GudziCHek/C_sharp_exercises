Console.WriteLine("Введите радиус окружности:");
decimal radius = Convert.ToDecimal(Console.ReadLine());

decimal pi = (Decimal)Math.PI;
decimal surface = 4 * pi * radius * radius;
decimal volume = 4 / 3 * pi * radius * radius * radius;
Console.WriteLine("Площадь окружности = {0:F2}", surface);
Console.WriteLine("Объём окружности = {0}", volume);