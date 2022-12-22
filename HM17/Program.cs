Console.WriteLine("x: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("y: ");
int y = int.Parse(Console.ReadLine());
if (x !=0 && y != 0)
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("1я четверть");
    }
    else if (x< 0 && y > 0)
    {
        Console.WriteLine("2я четверть");
    }
    else if (x< 0 && y < 0)
    {
        Console.WriteLine("3я четверть");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("4я четверть");
    }
}
else
{
    Console.WriteLine("Введите координаты НЕ равные 0");
}