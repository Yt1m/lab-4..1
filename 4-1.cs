double[] array = new double[14];
Console.WriteLine("Введите 14 элеменов массива:");
for (int i = 0; i < 14; i++)
{
    array[i] = double.Parse(Console.ReadLine());
}
int halfLength = array.Length / 2;
int swapsCount = SwapElements(array, halfLength);
Console.WriteLine($"Измененный массив:{string.Join(", ", array)}");
Console.WriteLine($"Количество перестановок {swapsCount}");
Console.ReadLine();
static int SwapElements(double[] array, int halfLength)
{
    int swapsCount = 0;
    for (int i = 0; i < halfLength; i++)
    {
        double temp = array[i];
        array[i] = array[i + halfLength];
        array[i + halfLength] = temp;
        swapsCount++;
    }
    return swapsCount;
}
