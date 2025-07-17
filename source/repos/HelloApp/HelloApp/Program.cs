Console.WriteLine("Введите длину прямоугольника:");
decimal width = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Введите ширину прямоугольника:");
decimal height = Convert.ToDecimal(Console.ReadLine());
if (width != 0 && height != 0)
{    
    decimal Perimeter = (width + height) * 2;
    decimal Area = width * height;
    decimal Diagonal = (decimal)Math.Sqrt((double)(width * width + height * height));
    Console.WriteLine("Периметр = {0}", Perimeter);
    Console.WriteLine("Площадь = {0}", Area);
    Console.WriteLine("Диагональ = {0}", Diagonal);
}
else
{
    decimal Perimeter = (width + height) * 2;
    decimal Area = width * height;
    Console.WriteLine("Периметр = {0}", Perimeter);
    Console.WriteLine("Площадь = {0}", Area);
    Console.WriteLine("Диагональ невозможно вычислить.");
}