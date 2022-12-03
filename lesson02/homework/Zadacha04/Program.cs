double Input(int a)
{
    Console.WriteLine($"Введите {a} число для сравнения");
    double b= Convert.ToDouble(Console.ReadLine());
    return b;
}

double [] DataInput(int AmountOfNumbers)
{
    int i = 0;
    double [] array = new double[AmountOfNumbers];
    while (i<AmountOfNumbers)
    {
        array[i]=Input(i+1);
        i++;
    }
    return array;
}

double Comparison(double [] array)
{
    double max = array[0];
    int i = 0;
    while (i< array.Length-1)
    {
        if (array[i+1]>max)
        {
            max = array[i+1];
        }
        i++;
    }
    return max;
}

Console.WriteLine("Введите сколько цифр нужно сравнить?");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Максимальное число {Math.Round(Comparison(DataInput(a)),2)}");