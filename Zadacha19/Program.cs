// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int GetUserValue(string message)
{
    Console.WriteLine (message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

string CheckPolindrom (int n)
{
    if (n%100 == (n/10000+ ((n/1000)%10)*10))
    {
      return "Число является полиндромом";  
    }
    else return "Число не является полиндромом";
}   


int number = GetUserValue("Введите пятизначное число");
string result = CheckPolindrom (number);

Console.WriteLine($"Вывод: {result}");