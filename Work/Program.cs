﻿using static System.Console;
Clear();

string? yesNo = "";
while (yesNo.ToLower() != "да" && yesNo.ToLower() != "нет")
{
    Write("Ввести строки вручную? (да/нет): ");
    yesNo = ReadLine();
}

string[] arrayOfStrings = new string[] { };

if (yesNo.ToLower() == "да")
{
    int n = InputNumbers("Введите количество элементов массива: ");
    arrayOfStrings = new string[n];
    for (int i = 0; i < arrayOfStrings.Length; i++)
    {
        Write($" Введите {i + 1} строку: ");
        arrayOfStrings[i] = ReadLine();
    }
}
else
{
    arrayOfStrings = new string[] { "12547", "2", "23", "cola" };
}
