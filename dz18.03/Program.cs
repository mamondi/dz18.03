
class Program
{
    static void Main(string[] args)
    {
        Shape circleRed = new Circle(new RedColor());
        Shape circleBlue = new Circle(new BlueColor());
        Shape rectangleRed = new Rectangle(new RedColor());
        Shape rectangleBlue = new Rectangle(new BlueColor());

        circleRed.Draw();
        circleBlue.Draw();
        rectangleRed.Draw();
        rectangleBlue.Draw();
    }
}
