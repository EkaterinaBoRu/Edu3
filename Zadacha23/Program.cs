// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int GetUserValue(string message)
{
    Console.WriteLine (message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

void GetKvadrat(int n)
{
    if (n > 1)
    {
        for (int i=1; i<= n; i++)
    {
        int temp = i*i*i;
        Console.Write($" {temp},");
    }
    }
    else Console.WriteLine("Число ненатуральное");
}

int N = GetUserValue("Введите число N");
GetKvadrat(N);