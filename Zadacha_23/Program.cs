/* Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N.
3 -> 1, 4, 9 ?????? Это я так понимаю таблица квадратов, а не кубов.
5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine("Введите число N:   ");
string numberN = Console.ReadLine();
int N = Convert.ToInt32(numberN);


int[] GetCubeTable(int N)
{
    int[] cubs = new int[N];
    int number = 1;
    for (int i = 0; i < N; i++)
    {
        cubs[i] = number * number * number;
        number++;
    }
    return cubs;
}

void TableCubs(int[] array)
{
    int number = 1;
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{number} в кубе = ");
        System.Console.WriteLine(array[i]);
        number++;
    }
}

int[] CubeTable = GetCubeTable(N);
TableCubs(CubeTable);