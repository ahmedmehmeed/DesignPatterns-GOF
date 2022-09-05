public abstract class  ShippingService
{
  public abstract int getShippingPercentage { get; }

    public override string ToString() => GetType().Name;
}

public class Landshipping : ShippingService
{
    public override int getShippingPercentage => 15;
}

public class Airshipping : ShippingService
{
    public override int getShippingPercentage => 20;

}

