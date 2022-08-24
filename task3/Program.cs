Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
int max = 0;
int min = 0;
FillArray(numbers);
for (int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] > numbers[numbers.Length -1])
    {
        max = numbers[i];
    }
    if(numbers[i] < numbers[numbers.Length - 1])
    {
        min = numbers[i];
    }
}
PrintArray(numbers);
Console.WriteLine();
Console.WriteLine($"Разница между {max} и {min}: {max - min} ");


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 20);
    }
}
