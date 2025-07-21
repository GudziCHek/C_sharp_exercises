Console.WriteLine("Введите длину массива:");
int x = Convert.ToInt32(Console.ReadLine());

int[] array = new int[x];
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Значение {i + 1} - ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

string input;

do
{
    Console.WriteLine("Введите число для поиска (или 'end' для выхода):");
    input = Console.ReadLine();

    if (string.IsNullOrEmpty(input) || input.ToLower() == "end")
    {
        break;
    }

    if (int.TryParse(input, out int y))
    {
        bool found = false;

        foreach (int num in array)
        {
            if (num == y)
            {
                found = true;
                break;
            }
        }

        Console.WriteLine(found ? $"Число {y} существует" : $"Число {y} не существует");
    }
    else
    {
        Console.WriteLine("Ошибка! Введите число или 'end'.");
    }
}
while (true);