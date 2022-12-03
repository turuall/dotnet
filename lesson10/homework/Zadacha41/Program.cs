

double InputData(string text)
{
    int data = 0;
    bool check = false;
    while (!check)
    {
        Console.Write($"Введите {text}: ");
        string input = Console.ReadLine();
        check = int.TryParse(input, out data);
    }
    return Convert.ToDouble(data);
}

(double, double) Point(double k1, double b1, double k2, double b2)
{
    double x = 0;
    double y = 0;

    x = (b2 - b1) / (k1 - k2);
    x = Math.Round(x, 2);
    y = Math.Round(k1 * x + b1, 2); 

    return (x, y);
}

bool CheckParallel(double k1, double k2) {return k1 == k2;}
bool CheckOrdinate(double b1, double b2) {return b1 == b2;}

void PrintResult(double k1, double b1, double k2, double b2, double x, double y)
{
    string output = $"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}; {y})";
    Console.WriteLine(output);
}

Console.WriteLine("start");
double k1 = InputData("k1");
double b1 = InputData("b1");
double k2 = InputData("k2");
double b2 = InputData("b2");
if (CheckParallel(k1, k2) && CheckOrdinate(b1, b2)) Console.WriteLine("Линии совпадают!");
else if (CheckParallel(k1, k2)) Console.WriteLine("Линии параллельны!");
else
{
    (double x, double y) = Point(k1, b1, k2, b2);
    PrintResult(k1, b1, k2, b2, x, y);
}
Console.WriteLine("end");