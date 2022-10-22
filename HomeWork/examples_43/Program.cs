// Напишите программу которая найдет точку пересечение двух прямых заданных уравнениями у=к1*х + в1, у=к2*х + в2, значения в1, в2 к1, к2 задаются пользователем. 
Console.Clear();

double b1 = Getusernum("Введи значение b1 ", "Ошибка ввода");
double k1 = Getusernum("Введи значение k1 ", "Ошибка ввода");
double b2 = Getusernum("Введи значение b2 ", "Ошибка ввода");
double k2 = Getusernum("Введи значение k2 ", "Ошибка ввода");

double x = koordX(b1, k1, b2, k2);

double y = koordY(x, k1, b1);

Console.Write($"b1={b1}, k1={k1}, b2={b2}, k2={k2} -> {x}, {y}");

///////////////////////////
double Getusernum(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (double.TryParse(Console.ReadLine(), out double num))
            return num;
        Console.WriteLine(errorMessage);

    }
}

double koordX(double b1, double k1, double b2, double k2)
{
    double x = (b1 - b2) / (k2 - k1);
    return x;
}

double koordY(double x, double k1, double b1)
{
    double y = k1 * x + b1;
    return y;
}