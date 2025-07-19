Console.WriteLine("Введите первое число:");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int num2 = int.Parse(Console.ReadLine());

Random random = new Random();
int rndNum = random.Next(num1, num2 + 1);
Console.WriteLine(rndNum);