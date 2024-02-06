//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []

// Input array of strings
Console.WriteLine("Enter strings separated by space:");
string[] inputArray = Console.ReadLine().Split(' ');

string[] resultArray = FilterStrings(inputArray);

Console.WriteLine("Result:");
foreach (string str in resultArray)
{
    Console.Write(str + " ");
}


static string[] FilterStrings(string[] inputArray)
{
    int count = 0;

    // Count the number of strings with length <= 3
    foreach (string str in inputArray)
        if (str.Length <= 3)
        {
            count++;
        }

    // Create a new array with the appropriate size
    string[] resultArray = new string[count];

    int index = 0;
    foreach (string str in inputArray)
        if (str.Length <= 3)
        {
            resultArray[index++] = str;
        }

    return resultArray;
}

