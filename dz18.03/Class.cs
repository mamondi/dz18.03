using System;

public class GeoCoordinatesAdapter : IGeoCoordinates
{
    private int x;
    private int y;

    public GeoCoordinatesAdapter(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public double Latitude => ConvertToLatitude(x);
    public double Longitude => ConvertToLongitude(y);

    private double ConvertToLatitude(int x)
    {
        return x * 0.5;
    }

    private double ConvertToLongitude(int y)
    {
        return y * 0.5;
    }
}
