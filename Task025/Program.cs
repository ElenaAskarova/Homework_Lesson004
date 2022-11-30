// метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B
void ExpNumber(int a, int b)
{
    int res = 1;
    for(int i = 1; i <= b; i++)
    {
        res = res * a;
    }
    Console.WriteLine(a + " в степени " + b + " = " + res);
}
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int numA = ReadInt("Введите число: ");
int numB = ReadInt("Введите степень: ");
ExpNumber(numA, numB);
