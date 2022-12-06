// Просим пользователя задать массив из строк и 
// выводим на экран все элементы массива, размер которых меньше или равен 3

string[] ParseArray(string[] array) 
{
    string[] arrayTemp = new string[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) 
        {
            Array.Resize(ref arrayTemp, arrayTemp.Length + 1); 
            arrayTemp[arrayTemp.Length - 1] = array[i];
        }
    }
    return arrayTemp;
}

void PrintArray(string[] array, string message)
{
    string result = message;
    if (array.Length == 0)
    {
        result += "Элементов в массиве не обнаружено";
    }
    for (int i = 0; i < array.Length; i++)
    {
        result += $"{array[i]}, ";
    }
    Console.WriteLine(result.TrimEnd(' ', ','));
}

void Main()
{
    Console.WriteLine("Введите любое первое тестовое / буквенное / символьное значение: ");
    string Message1 = Console.ReadLine();
    Console.WriteLine("Введите любое второе тестовое / буквенное / символьное значение: ");
    string Message2 = Console.ReadLine();
    Console.WriteLine("Введите любое третье тестовое / буквенное / символьное значение: ");
    string Message3 = Console.ReadLine();
    string[] array = new string[] { Message1, Message2, Message3 };
    PrintArray(array, "Заданный массив: ");
    string[] arrayFinal = ParseArray(array);
    PrintArray(arrayFinal, "Массив строк с количеством элементов менее или равном трем: ");
    System.Console.WriteLine();
}

Main();

