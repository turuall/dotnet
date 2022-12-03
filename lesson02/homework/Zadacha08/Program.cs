int Input()
{
    Console.WriteLine("Введите N");
    return Convert.ToInt32(Console.ReadLine());
}

void Output(int N)
{
    int i = 1;
    while (i <= N)
    {
        if (i % 2 == 0)
        {
            Console.Write($"{i}, ");
        }
        i++;
    }
}

Output(Input());
