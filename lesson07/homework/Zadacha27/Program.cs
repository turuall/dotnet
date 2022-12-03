int Input()
{
    int i = 0;
    bool flag = false;
    while(!(flag && i>0))
    {
        Console.WriteLine("Введите число");
        flag = int.TryParse(Console.ReadLine(), out i);
    }      
    return i;
}

int Calculate(int a)
{
    int result = 0;
    while(a>0)
    {
        result+=a%10;
        a/=10;        
    }
    return result;
} 

void Output(int a)
{    
    Console.WriteLine($"сумма чисел в числе {a}");     
}

Output(Calculate(Input()));