// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина
// которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать
// на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

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
    Array.Resize(ref newArray, j);
    return newArray;
}

string[] array = new string[6] {"d4r", "e2d2", "dswf3", "i", "w14", "1j"};
System.Console.Write($"[{string.Join(", ", array)}]");

System.Console.WriteLine(String.Empty);
string[] newArray = CreateThreeSymbolsArray(array);

System.Console.Write($"[{string.Join(", ", newArray)}]");