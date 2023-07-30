// Задача: Написать программу, которая из имеющегося массива 
// строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с 
// клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] InputArray(string message)
{
    Console.WriteLine(message); //Обращение к пользователю в консоли
    string input = Console.ReadLine()!; //Ввод пользователем значений
    string[] inputArray = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries); //Разделение введенных пользователем значений на элементы массива 
    return inputArray; //Возврат полученного массива
}

string[] FilterShortStrings(string[] inputArray)
{
    //Подсчёт количества элементов массива, длина которых меньше или равна трём символам
    int count = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            count++;
        }
    }
    //Создание нового результирующего массива, количество элементов которого равно подсчитанным элементам оригинального массива
    string[] resultArray = new string[count];
    //Заполнение нового массива через цикл for
    int index = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            resultArray[index] = inputArray[i];
            index++;
        }
    }
    //Вывод заполненного нового массива
    return resultArray;
}

void WriteArray(string[] resultArray)
{
    //Вывод нового массива в консоль
    Console.WriteLine("Новый массив из строк с длиной меньше или равной 3 символам:");
    foreach (string str in resultArray)
        Console.Write(str + " ");
}

string[] strArray = InputArray("Введите элементы массива через запятую:");
string[] resArray = FilterShortStrings(strArray);
WriteArray(resArray);