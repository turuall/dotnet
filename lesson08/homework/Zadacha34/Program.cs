int InputSize()
{
    Console.Write("Введите размер массива: ");
    int s = Convert.ToInt32(Console.ReadLine());
    return s;
}

int[] ArrayCreate(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

int CountMod2To0(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) result += 1;
    }
    return result;
}

void PrintResult(int[] arr, int result)
{
    string output = $"{string.Join(',', arr)} -> {result}";
    Console.WriteLine(output);
}

Console.WriteLine("start");
int size = InputSize();
int[] numbers = ArrayCreate(size);
int result = CountMod2To0(numbers);
PrintResult(numbers, result);
Console.WriteLine("end");