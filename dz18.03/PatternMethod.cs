// Реалізатор
public interface IColor
{
    string Fill();
}

// Конкретний реалізатор
public class RedColor : IColor
{
    public string Fill()
    {
        return "Червоний";
    }
}

public class BlueColor : IColor
{
    public string Fill()
    {
        return "Синiй";
    }
}
