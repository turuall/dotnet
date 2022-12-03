int Input()
{
    Console.WriteLine("Введите трехзначное число");
    return Convert.ToInt32(Console.ReadLine());
}

void Calculation(int n)
{
    Console.WriteLine("Вторая цифра равна - " + (n % 100)/10);
}

Calculation(Input());