
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
