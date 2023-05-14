// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше,
//  либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


int userQantity = GetQantityFromUser("Введите количество элементов массива строк: ", "Ошибка ввода!");
string[] array = FillArrayFromUser("Введите строку: ", userQantity);
string[] result = GetNewArray(array);
Console.WriteLine($"[{String.Join(", ", array)}] -> [{String.Join(", ", result)}]");

int GetQantityFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber > 0)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

string[] FillArrayFromUser(string message, int num)
{
    string[] array = new string[num];
    for (int i = 0; i < num; i++)
    {
        Console.Write(message);
        array[i] = Console.ReadLine() ?? "";
    }
return array;
}

string[] GetNewArray(string[] arr)
{
    int count = 0;
    string[] result = new string[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) 
        {
            result[count] = arr[i];
            count++;
        }
    }
    return result;
}