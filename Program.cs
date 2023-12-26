using System;

class Program
{
    static void Main()
    {
        // Шаг 1: Получение ввода от пользователя
        string[] input = GetString();

        // Шаг 2: Фильтрация строк по длине
        string[] output = FindLess(input, 3);

        // Шаг 3: Вывод результатов
        Console.WriteLine($"{string.Join(", ", input)} -> {string.Join(", ", output)}");
    }

    // Шаг 1: Получение ввода от пользователя
    static string[] GetString()
    {
        Console.WriteLine("Введите значения через запятую : ");
        string input = Console.ReadLine() ?? string.Empty;

        // Проверка на null, разделение строки на массив и фильтрация пустых строк
        return !string.IsNullOrEmpty(input)
            ? input.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
            : Array.Empty<string>();
    }

    // Шаг 2: Фильтрация строк по длине
    static int GetLength(string[] arr, int n)
    {
        int len = 0;

        // Проверка на null и фильтрация по длине
        if (arr != null)
        {
            for (int k = 0; k < arr.Length; k++)
            {
                if (!string.IsNullOrEmpty(arr[k]) && arr[k].Length <= n)
                    len++;
            }
        }
        return len;
    }

    // Шаг 2: Фильтрация строк по длине
    static string[] FindLess(string[] inputMassiv, int n)
    {
        // Шаг 2.1: Создание нового массива
        string[] result = new string[GetLength(inputMassiv, n)];

        // Шаг 2.2: Фильтрация строк
        if (inputMassiv != null)
        {
            for (int i = 0, j = 0; i < inputMassiv.Length; i++)
            {
                // Проверка на null, на пустую строку и фильтрация по длине
                if (!string.IsNullOrEmpty(inputMassiv[i]) && inputMassiv[i].Length <= n)
                {
                    result[j] = inputMassiv[i];
                    j++;
                }
            }
        }
        return result;
    }
}

