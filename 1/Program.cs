//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Exponentiation(int number, int ext)
{
    int result = number;

    for (int i = 1; i < ext; i++)
    {
        result = result * number;
    }
    return result;
}

int number = GetInfo("Введите число: ");
int ext = GetInfo("Введите степень: ");
int result = Exponentiation(number, ext);
Console.WriteLine($"Вывод через переменную: {number}, {ext} -> {result}");
Console.WriteLine($"Вывод через метод: {number}, {ext} -> {Exponentiation(number, ext)}");


