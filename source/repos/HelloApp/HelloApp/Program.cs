int[] numbers = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Введите число {i + 1}:");
    numbers[i] = int.Parse(Console.ReadLine());
}

Array.Reverse(numbers);
Console.WriteLine(string.Join(" ", numbers));