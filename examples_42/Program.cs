// Напишите программу которая будет преобразовывать десятичное число в двоичное
Console.Clear();

int usernum = Getusernum("Введи целое десятичное число ", "Ошибка ввода");
string newnum = preobrazovanie(usernum);
Console.Write(usernum + " -> " + newnum);









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

string preobrazovanie(int us)
{
    string FinishNum = "";
    while (us > 0)
    {
        int a = us % 2;
        FinishNum = a + FinishNum;
        us = us / 2;
    }
    return FinishNum;

}