string[] CreateStringArray(int size = 5)
{
    return new string[size];
}

void FillStringArrayConsole(string [] array)
{
    Console.WriteLine($"Задан массив строк, длиной {array.Length}.");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1}-й элемент массива строк: ");
        array[i] = Console.ReadLine();
        Console.WriteLine();
    }
}

int DeterminingLengthResultArray(string[] array, int value)
{
    int lenResult = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= value) lenResult ++;
    }
    return lenResult;
}

void FillResultArray(string [] array, string [] result, int value)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= value)
        {
            result[j] = array[i];
            j ++;
        }
    }
}

void OutputArrayConsole(string [] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{(char)34}{array[i]}{(char)34}, ");
    }
    Console.WriteLine("]");
}

string OutputArrayString(string [] array)
{
    string result = string.Empty;
    result = "[ ";
    for (int i = 0; i < array.Length; i++)
    {
        result += $"{array[i]} ";
    }
    result += "]";
    return result;
}

string[] received = CreateStringArray();
FillStringArrayConsole(received);
OutputArrayConsole(received);
int value = 3;
int lenResult = DeterminingLengthResultArray(received, value);
string[] result = CreateStringArray(lenResult);
FillResultArray(received, result, value);
OutputArrayConsole(result);
string resultString = OutputArrayString(result);
