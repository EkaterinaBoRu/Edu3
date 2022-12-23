// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

int GetUserValue(string message)
{
    Console.WriteLine (message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

double GetDistanseCoordinate (int userAx, int userAy, int userAz, int userBx, int userBy, int userBz)
{
    double result = Math.Sqrt(Math.Pow((userAx -userBx), 2) +Math.Pow((userAy -userBy), 2)+ Math.Pow((userAz -userBz), 2));
    return result;
}

int userAx = GetUserValue("Введите координату X числа A");
int userAy = GetUserValue("Введите координату Y числа A");
int userAz = GetUserValue("Введите координату Z числа A");

int userBx = GetUserValue("Введите координату X числа B");
int userBy = GetUserValue("Введите координату Y числа B");
int userBz = GetUserValue("Введите координату Z числа B");

double distanse = Math.Round(GetDistanseCoordinate(userAx, userAy, userAz, userBx, userBy, userBz), 2);

Console.WriteLine($"Расстояние между точками A и B: {distanse}");