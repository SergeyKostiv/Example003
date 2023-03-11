﻿// ==== Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

/*
string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            +"вы бы взяли приступом согласие прусского короля."
            +"Вы так красноречивы. Вы дадите мне чаю?";

            // string s = "qwerty"
            //             012
            // s[3] r

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}
string newText = Replace(text, ' ', '|');

Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);
newText = Replace(text, 'С', 'С');
Console.WriteLine(newText);
*/

// 1. Найти позицию минимального элемента в неотсортированной части массива.
// 2. Произвести обмен этого значения со значением первой неотсортированной позиции.
// 3. Повторять пока есть неотсортированные элементы.

int[] arr = { 1, 5, 4, 3, 2, 6, 7};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionsSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionsSort(arr);

PrintArray(arr);
