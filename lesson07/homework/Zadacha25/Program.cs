int Input (string a)
{
    int i = 0;
    bool flag = false;
    while (!flag)
    {
        Console.WriteLine(a);
        flag = int.TryParse(Console.ReadLine(), out i);
    }
    return i;
}

int Calculation(int a, int b)
{
    int result = 1;
    for(int i=1; i<=b; i++)
    {
        result*=a;
    }
    return result;
}

void Output(int a, int b, int result)
{
    Console.WriteLine($"{a}^{b} -> {result}");
}

int a = Input ("Введите возводимое число");
int b = Math.Abs(Input ("Введите требуемую степень"));
Output(a, b, Calculation(a, b));