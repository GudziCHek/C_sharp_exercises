Console.WriteLine("Введите расстояние в метрах:");
decimal distance = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Введите время в часах:");
decimal time_per_hour = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Введите время в минутах:");
decimal time_per_minute = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Введите время в секундах:");
decimal time_per_second = Convert.ToDecimal(Console.ReadLine());

decimal total_sec = time_per_hour * 3600 + time_per_minute * 60 + time_per_second;
if (total_sec == 0)
{
    Console.WriteLine("Ошибка: время не может быть нулевым.");
    return;
}

decimal speed_in_meters_per_sec = distance / total_sec;
decimal speed_in_kilometers_per_hour = (distance / 1000) / (total_sec / 3600);
decimal speed_in_miles_per_hour = (distance / 1609) / (total_sec / 3600);
Console.WriteLine("Скорость в м/c = {0}", speed_in_meters_per_sec);
Console.WriteLine("Скорость в км/ч = {0}", speed_in_kilometers_per_hour);
Console.WriteLine("Скорость в миль/ч = {0}", speed_in_miles_per_hour);