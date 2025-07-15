Console.WriteLine("Введите значение x:");
decimal x = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Введите значение y:");
decimal y = Convert.ToDecimal(Console.ReadLine());
if (y == 0)
{ 
    Console.WriteLine("Cannot divide by 0"); 
}
else
{
    decimal answer = x / y;
    Console.WriteLine(answer);
}

// Также можно решить эту задачу следующим образом

try
{
    decimal answer = x / y;
    Console.WriteLine(answer);
}
catch(DivideByZeroException)
{
    Console.WriteLine("Cannot divide by 0");
}