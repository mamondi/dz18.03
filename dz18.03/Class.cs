// Абстракція
public abstract class Shape
{
    protected IColor color;

    public Shape(IColor color)
    {
        this.color = color;
    }

    public abstract void Draw();
}

// Розширена абстракція
public class Circle : Shape
{
    public Circle(IColor color) : base(color) { }

    public override void Draw()
    {
        Console.WriteLine($"Намальовано коло. Колiр: {color.Fill()}");
    }
}

public class Rectangle : Shape
{
    public Rectangle(IColor color) : base(color) { }

    public override void Draw()
    {
        Console.WriteLine($"Намальовано прямокутник. Колiр: {color.Fill()}");
    }
}
