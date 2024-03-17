public interface IGeoCoordinates
{
    double Latitude { get; }
    double Longitude { get; }
}

public class OldComponent
{
    public void ProcessCoordinates(int x, int y)
    {
        Console.WriteLine($"Обробка координат: ({x}, {y})");
    }
}