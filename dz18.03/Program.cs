class Program
{
    static void Main(string[] args)
    {
        OldComponent oldComponent = new OldComponent();

        IGeoCoordinates geoCoordinates = new GeoCoordinatesAdapter(10, 20);

        oldComponent.ProcessCoordinates((int)geoCoordinates.Latitude, (int)geoCoordinates.Longitude);
    }
}

//Приклад з чату гпт
//Припустимо, у нас є старий компонент, який працює із відомими географічними координатами
//у форматі (x, y), але ми хочемо використовувати його з новими данними, які використовуються
//у форматі (latitude, longitude)