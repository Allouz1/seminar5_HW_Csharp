Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
int count = 0;
FillArray(numbers);
for(int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] % 2 == 0)
    {
        count++;
    }
}
PrintArray(numbers);
Console.WriteLine();
Console.WriteLine(count);



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
        array[i] = new Random().Next(100, 1000);
    }
}

