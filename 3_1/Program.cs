//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

//Ввод в ручную (8 элементов)

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int [] ArrInput ()
{
    int [] arr = new int[8];
    for (int i = 0; i < 8; i++)
    {
        int numberArr = GetInfo($"Введите {i + 1} элемент массива: ");
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

int [] arr = ArrInput();

// Вывод через Join

Console.WriteLine($"Вывод через Join: {string.Join(", ", arr)} - > [{string.Join(", ", arr)}]");

// Вывод через for

ArrOutput(arr);
