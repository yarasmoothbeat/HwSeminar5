Double[] CreateRandomArray(int size)
{
    Double[] array = new Double[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = (new Random().Next(10) + Math.Round(new Random().NextDouble(), 2));
    }

    return array;
}

void PrintArray(Double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write( array[i] + " " );
    }
}

void CheckDifference(double[] array)
{
    int i = 0;
    double min = array[i];
    double max = 0;
    double diff = 0;
    for(i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        if (array[i] > max)
        {
            max = array[i];
        }
        diff = (max - min);   
    }
    Console.WriteLine($" Разница между минимальным - {min} и максимальным - {max} элементом - {diff}");
}

System.Console.WriteLine("Input array size: " );
int size = Convert.ToInt32(Console.ReadLine());

Double[] myArray = CreateRandomArray(size);
PrintArray(myArray);
CheckDifference(myArray);