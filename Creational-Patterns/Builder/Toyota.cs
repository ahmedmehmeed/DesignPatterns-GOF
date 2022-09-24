
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
