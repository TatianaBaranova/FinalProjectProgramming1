string[] array = {"Hello","2","world",":-)"};

PrintArray(FormArrayWithLength(array));

string[] FormArrayWithLength(string[] arrayInput)
{
    string[] resultArray = new string[arrayInput.Length];
    for (int i = 0; i < arrayInput.Length; i++)
    {
        int length = arrayInput[i].Length;
        if (length <= 3)
        {
            resultArray[i] = arrayInput[i];
        }
    }
    return resultArray;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
