public class Garage
{
    private  CarBuilder? _carBuilder;

    public Garage()
    {

    }
    public void  Build(CarBuilder carBuilder)
    {
        _carBuilder = carBuilder;
        carBuilder.BuildFrame();
        carBuilder.BuildEngine();
    }

    public void Test()
    {
        Console.WriteLine(_carBuilder.Car.ToString());
    }


}
