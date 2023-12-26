# Итоговая контрольная работа по основному блоку
*    ### Ход выполнения:
   1. Создать репозиторий на GitHub
   2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
   3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
   4. Написать программу, решающую поставленную задачу
   5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

*    ### Задание:
>Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

***Примеры:***

**[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]**

**[“1234”, “1567”, “-2”, “computer science”] → [“-2”]**

**[“Russia”, “Denmark”, “Kazan”] → []**

*    ### Блок-схема алгоритма:
![](https://i.ibb.co/BNRfrsc/block-sxema.png)

*    ### Код программы:
```
    using System;

    class Program
    {
    static void Main()
    {
        //Шаг 1: Получение ввода от пользователя 
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
```

*    ### Вывод в терминале:
![](https://i.ibb.co/B4ZdQgH/vyvod1.jpg)