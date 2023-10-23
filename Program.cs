﻿// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина
// которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать
// на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

void PrintArray(string[] array)
{
    System.Console.WriteLine();
    foreach (string item in array)
    {
        System.Console.Write(item + " ");
    }
}

void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine()!;
    }
}

string[] CreateThreeSymbolsArray(string[] array)
{
    string[] newArray = new string[array.Length];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            {
                newArray[j] = array[i];
                j++;
            }
    }
    return newArray;
}

string[] array = new string[6] {"dj4r", "e22", "da9sw", "10y", "w1234", "1j"};
PrintArray(array);

string[] newArray = CreateThreeSymbolsArray(array);
PrintArray(newArray);