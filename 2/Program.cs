//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbers(int number)
{
int result = number % 10;
for (int i = 0; i < number; i++)
{
    number = number / 10;
    result = result + number % 10; 
}
return result;
}

int number = GetInfo("Введите число: ");
int result = SumNumbers(number);
Console.WriteLine($"{number} -> {result}");

