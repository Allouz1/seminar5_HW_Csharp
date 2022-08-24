Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
int sum = 0;
FillArray(numbers);
for (int i = 0; i < numbers.Length; i++)
{
    if(i % 2 != 0 )
    {
        sum += numbers[i];
    }
}
PrintArray(numbers);
Console.WriteLine();
Console.WriteLine(sum);





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
        array[i] = new Random().Next(0, 10);
    }
}

