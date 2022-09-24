
/// <summary>
/// Builder 
/// </summary>
public abstract class CarBuilder
{
    public car Car { get; set; }
    public CarBuilder(String type)
    {
        Car = new car(type);
    }
    public abstract void BuildEngine();
    public abstract void BuildFrame();
}
