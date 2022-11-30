// метод, который задаёт массив из 8 элементов и выводит их на экран. 
//Я так поняла, что элементы массива не рандомные, а вводятся пользователем
//В примеерах задачи указаны массивы не с восемью элементами, 
//поэтому в проверке dotnet run я добавляла свои числа

// метод, считывающий число из консоли
int GetNumber(string text)
{
    Console.Write(text);
    int value = int.Parse(Console.ReadLine());
    return value;
}


// метод, создающий массив с указанным количеством элементов
int[] CreateArray(int count)
{
    return new int[count];
}


//метод, заполняющий маассив поэлементно от пользователя
void Fill(int[] array)
{
    int size = array.Length;
    int index = 0;
    while(index < size)
    {
        array[index] = GetNumber($"array[{index}]: ");
        index++;
    }
}

//метод, печатающий массив
void PrintBad(int[] numbers)
{
    int size = numbers.Length;
    int i = 0;
    while(i < size)
    {
        Console.Write($"{numbers[i]} ");
        i++;
    }
}

//метод, печатающий массив
string PrintGood(int[] numbers)
{
    int size = numbers.Length;
    int i = 0;
    string result = "[ ";
    while (i < size)
    {
        result += ($"{numbers[i]} ");
        i++;
    }
    return result + "]";
}

int countElements = 8;
int[] arr = CreateArray(countElements);
Fill(arr);
PrintBad(arr);
Console.WriteLine(PrintGood(arr));

