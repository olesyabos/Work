using static System.Console;
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
int lengthLimit = 3;

int numbersItems = CheckArray(arrayOfStrings, lengthLimit);

string[] newArrayOfStrings = new string[numbersItems];

FillNewArray(arrayOfStrings, newArrayOfStrings, lengthLimit);

int CheckArray(string[] array, int lengthLimit)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= lengthLimit) result++;
    }
    return result;
}

void FillNewArray(string[] oldArray, string[] newArray, int lengthLimit)
{
    int temp = 0;
    for (int i = 0; i < oldArray.Length; i++)
    {
        if (oldArray[i].Length <= lengthLimit)
        {
            newArray[temp] = oldArray[i];
            temp++;
        }
    }
}

