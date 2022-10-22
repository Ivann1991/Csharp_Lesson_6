// Пользователь вводит с кливиатуры М чисел. Посчитайте сколько чисел больше 0 ввел пользователь.


Console.Clear();

int CountElement = EnterUserNum("Какое количество чисел желаешь ввести? ", "ошибка ввода");

int[] UserArray = EnterArrayElement(CountElement);

int Number = CountNum (UserArray);
Console.Write("Ты ввел числа: ");
Console.Write(String.Join(", ", UserArray));

Console.Write($", из них {Number} больше нуля");


/////////////////////////// методы
int EnterUserNum(string message, string errorMessage)        // количество элементов массива, ввод с клавиатуры
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int num))
            return Math.Abs(num);
        Console.WriteLine(errorMessage);

    }
}

int EnterElement(string message, string errorMessage)        // элементы массива, ввод с клавиатуры
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int num))
            return num;
        Console.WriteLine(errorMessage);

    }
}

int[] EnterArrayElement(int size)                            // Заполнение элементов массива с клавиатуры

{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        int element = EnterElement($"Введи {i + 1}-е число ", "ошибка ввода");

        array[i] = element;
    }
    return array;
}

int CountNum(int[] array)                                    // Определение количества чисел больше нуля 
{
    int Count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0)
            Count++;
    return Count;        
}