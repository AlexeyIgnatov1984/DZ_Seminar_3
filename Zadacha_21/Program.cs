/*
  Напишите программу, которая принимает на вход координаты 2-х точек и находит расстояние между ними в 3D пространстве.
  A(3, 6, 8); B(2, 1, -7) -> 15,84
  A(7, -5, 0) B(1, -1, 9) -> 11,53
*/

int GetNumber (string msg)
{
    while (true)
    {
        Console.WriteLine(msg);
        string valueFromConsole = Console.ReadLine();

        if (int.TryParse(valueFromConsole, out int number))
        {
            return number;
        }
        else
        {
            Console.WriteLine("Вы ввели не число. Нужно ввести число.");
        }
    }
}

double GetLengthVector (double x1, double x2, double y1, double y2, double z1, double z2)
{
    double difx = Math.Pow((x1 - x2), 2);
    double dify = Math.Pow((y1 - y2), 2);
    double difz = Math.Pow((z1 - z2), 2);
    double length = Math.Sqrt(difx + dify +difz);
    return length;
}

int x1 = GetNumber("Введите координату x1: ");
int y1 = GetNumber("Введите координату y1: ");
int z1 = GetNumber("Введите координату z1: ");
int x2 = GetNumber("Введите координату x2: ");
int y2 = GetNumber("Введите координату y2: ");
int z2 = GetNumber("Введите координату z2: ");

double result = GetLengthVector(x1, x2, y1, y2, z1, z2);
Console.WriteLine(result);
