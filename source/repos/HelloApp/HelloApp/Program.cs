Console.WriteLine("Введите числа:");
decimal a = Convert.ToDecimal(Console.ReadLine());
decimal b = Convert.ToDecimal(Console.ReadLine());
try
{
    var c = a + b;
    var d = a - b;
    var e = a * b;
    var f = a / b;
    var g = a % b;
    Console.WriteLine("{0} + {1} = {2}", a, b, c);
    Console.WriteLine("{0} - {1} = {2}", a, b, d);
    Console.WriteLine("{0} x {1} = {2}", a, b, e);
    Console.WriteLine("{0} / {1} = {2}", a, b, f);
    Console.WriteLine("{0} mod {1} = {2}", a, b, g);
}
catch(DivideByZeroException)
{
    var c = a + b;
    var d = a - b;
    var e = a * b;
    Console.WriteLine("{0} + {1} = {2}", a, b, c);
    Console.WriteLine("{0} - {1} = {2}", a, b, d);
    Console.WriteLine("{0} x {1} = {2}", a, b, e);
    Console.WriteLine("Операции на деление на ноль нельзя.");
}