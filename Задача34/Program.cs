int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 999 + 1);
    }

    return array;
}

void PrintArray(int[] array)

{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}

void EvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Количество четных чисел - {count}" );
}

int[] myArray = CreateRandomArray(5);
PrintArray(myArray);
EvenNumbers(myArray);