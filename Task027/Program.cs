// метод, который принимает на вход число и выдаёт сумму цифр в числе

//метод подсчета цифр в числе
int NumCount(int a)
{
    int i = 0;
    while (a > 0)
    {
        a = a / 10;
        i++;
    }
    return i;
}

//метод вывода суммы цифр в числе
void SumNum(int n, int count)
{
    int sum = 0;
    for(int j = 1; j <= count; j++)
    {
        sum = sum + n % 10;
        n = n / 10;
    }
    Console.WriteLine($"сумма цифр {sum}");
}

//метод ввода числа от пользователя
int ReadNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

//Клиентский код
int num = ReadNum("Введите число: ");
int count = NumCount(num);
SumNum(num, count);
