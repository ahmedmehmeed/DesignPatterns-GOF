

using System.Text;


/// <summary>
/// Builder 
/// </summary>
public abstract class  CarBuilder
{
    public car Car { get; set; }
    public CarBuilder(String type)
    {
        Car = new car(type);
    }
    public abstract void BuildEngine();
    public abstract void BuildFrame();
}




/// <summary>
/// Concrete Class1
/// </summary>
public class Mercedes : CarBuilder
{
    public Mercedes():base("Mercedes")
    {

    }
    public override void BuildEngine()
    {
        Car.AddParts("5000CC");
        Car.AddParts("Airbag");
    }

    public override void BuildFrame()
    {
        Car.AddParts("Black Frame");
    }
}

/// <summary>
/// Concrete Class2
/// </summary>
public class Toyota : CarBuilder
{
    public Toyota() : base("Toyota")
    {

    }


    public override void BuildEngine()
    {
        Car.AddParts("3000CC");
    }

    public override void BuildFrame()
    {
        Car.AddParts("Blue Frame");
    }
}



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


/// <summary>
/// Product
/// </summary>
public class car
{
    private  readonly List<string> _parts;
    private readonly string _carType;

    public car(string type)
    {
        _carType = type;
        _parts = new();
    }

    public void AddParts(string part)
    {
        _parts.Add(part);
    }
         


    public override string ToString()
    {
        var ST = new StringBuilder();

        foreach (var part in _parts)
        {
            ST.Append($"Car of {_carType} has part of {part}\n ");
        }

        return ST.ToString();
    }

}