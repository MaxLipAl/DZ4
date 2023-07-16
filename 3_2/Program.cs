//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

//Массив создается случайным методом из 8 элементов

int [] ArrInput (int number)
{
    int [] arr = new int[number];
    for (int i = 0; i < number; i++)
    {
        int numberArr = new Random().Next(number);
        arr[i] = numberArr;
    }
    return arr;
}

void ArrOutput (int[] arr)
{
    Console.Write($"Вывод через for: {string.Join(", ", arr)} - > [");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length - 1]}]");
}

int number = 8;
int [] arr = ArrInput(number);
Console.WriteLine($"Вывод через Join: {string.Join(", ", arr)} - > [{string.Join(", ", arr)}]");
ArrOutput(arr);
