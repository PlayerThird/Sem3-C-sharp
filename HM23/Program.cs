//Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 4, 9. 
//5 -> 1, 8, 27, 64, 125

using Standart;
int N;
N = ReadNumber.VvodInt($"Введите N: ");
Console.Write($"{N} -- > ");
for (int i = 1; i < N+1; i++)
{
    int x = Convert.ToInt32(Math.Pow(i, 3));
    Console.Write($"{x} - ");
}
