Console.WriteLine("Введите строки массива, разделяя их пробелом:"); // Запрос массива строк у пользователя
string input = Console.ReadLine()!;

string[] inputArray = input.Split(' '); // Разделение введенной строки на массив строк

// Определение размера нового массива
int newSize = 0;
for (int i = 0; i < inputArray.Length; i++)
{
    // Подсчет количества строк, длина которых меньше или равна 3 символам
    if (inputArray[i].Length <= 3)
    {
        newSize++;
    }
}

// Создание нового массива
string[] newArray = new string[newSize];

// Заполнение нового массива
int index = 0;
for (int i = 0; i < inputArray.Length; i++)
{
    // Заполнение нового массива строками, длина которых меньше или равна 3 символам
    if (inputArray[i].Length <= 3)
    {
        newArray[index] = inputArray[i];
        index++;
    }
}

// Вывод результата
Console.WriteLine("Новый массив строк с длиной меньше или равной 3 символам:");
foreach (string str in newArray)
{
    // Вывод строки, если она не равна null
    if (str != null)
    {
        Console.WriteLine(str);
    }
}