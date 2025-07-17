Console.WriteLine("Введите градусы в Цельсиях:");
decimal Celsius = Convert.ToDecimal(Console.ReadLine());

decimal Kelvin = Celsius + 273;
decimal Fahrenheit = (Celsius * (18 / 10)) + 32;
Console.WriteLine("Kelvin = {0}", Kelvin);
Console.WriteLine("Fahrenheit = {0}", Fahrenheit);