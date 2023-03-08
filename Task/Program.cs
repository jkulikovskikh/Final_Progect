string[] GetArray(string? str)
{
    Console.WriteLine(str);
    string[] result = Console.ReadLine()!.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

    return result;
}

string[] GetNewArray(string[] array)
{
    string[] result = new string[array.Length];

    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[j] = array[i];
            j++;
        }
    }

    Array.Resize(ref result, j);
    return result;
}

void PrintArray(string[] array)
{
    Console.WriteLine("[" + string.Join(","+" ", array) + "]");
}

var array = GetArray("Введите массив строк через пробел");
if (array.Length == 0)
    Console.WriteLine("Введена пустая строка");
else
{
    var result = GetNewArray(array);
    if (result.Length == 0)
        Console.Write("В введенном массиве строк нет строк, длина которых меньше либо равна 3 символа");
    else
        PrintArray(result);
}