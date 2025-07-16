Console.WriteLine("Введите диапозон чисел:");
int x1 = Convert.ToInt32(Console.ReadLine());
int x2 = Convert.ToInt32(Console.ReadLine());
int x;
if (x1 < x2)
{
    for (x = x1; x <= x2; x++)
    {
        int y = x * x - 2 * x + 1;
        Console.Write("{0} ", y);
    }
}
else
{
    for (x = x2; x <= x1; x++)
    {
        int y = x * x - 2 * x + 1;
        Console.Write("{0} ", y);
    }
}