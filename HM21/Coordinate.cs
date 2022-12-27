using Standart;
public class Coordinate
{
    public int X { get; private set; }
    public int Y { get; private set; }
    public int Z { get; private set; }
    public string Name { get; private set; }
    public Coordinate(string name)
    {
        this.Name = name;
        this.X = ReadNumber.VvodInt($"Введите координату {name} по оси Х");
        this.Y = ReadNumber.VvodInt($"Введите координату {name} по оси Y");
        this.Z = ReadNumber.VvodInt($"Введите координату {name} по оси Z");
    }
    public void Dlinna(Coordinate b)
    {
        double d = Math.Sqrt(Math.Pow(this.X - b.X, 2) + Math.Pow(this.Y - b.Y, 2) + Math.Pow(this.Z - b.Z, 2));
        Console.Write($"{this.Name}({this.X},{this.Y},{this.Z}), {b.Name}({b.X},{b.Y},{b.Z})");
        Console.WriteLine($" --> {d:f2}");
        //this.X это координата которая осталась в методе Coordinate
        //b.X координата переданная из Coordinate записанная в переменную b
    }
}
