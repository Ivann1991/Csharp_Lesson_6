// напишите программу, которая на вход принимает три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
//(каждая сторона треугольника меньше суммы двух других сторон)
Console.Clear();

int usernum1 = Getusernum("Введи длину первой стороны ", "ошибка ввода");
int usernum2 = Getusernum("Введи длину второй стороны ", "ошибка ввода");
int usernum3 = Getusernum("Введи длину третьей стороны ", "ошибка ввода");

bool result = proverkaNatreygolnik(usernum1, usernum2, usernum3);
if (result)
    Console.Write("треугольнику быть");
else
    Console.Write("тругольнику не быть");

///////////////////////////
int Getusernum(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int num))
            return num;
        Console.WriteLine(errorMessage);

    }
}

bool proverkaNatreygolnik(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b)
        return true;
    return false;
}