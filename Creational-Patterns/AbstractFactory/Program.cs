
/// <summary>
/// Abstract Factory
/// </summary>
public interface IShoppingCartFactory
{
    IDiscountService CreateDiscount();
    IShippingCostService CreateShippingCost();

}

/// <summary>
/// Abstract Product
/// </summary>
public interface IDiscountService
{
    int DiscountPercentage { get; }
}

/// <summary>
/// Abstract Product
/// </summary>
public interface IShippingCostService
{
    int ShippingCost { get; }

}

/// <summary>
/// Concrete Product
/// </summary>
public class RecentClothesDiscount : IDiscountService
{
    public int DiscountPercentage => 20;
}


/// <summary>
/// Concrete Product
/// </summary>
public class RecentFoodsDiscount : IDiscountService
{
    public int DiscountPercentage => 10;
}

/// <summary>
/// Concrete Product
/// </summary>
public class AlexShipingCostService : IShippingCostService
{
    public int ShippingCost => 500;
}

/// <summary>
/// Concrete Product
/// </summary>
public class CairoShipingCostService : IShippingCostService
{
    public int ShippingCost => 100;
}

/// <summary>
/// 
/// Concrete Factory
/// </summary>
public class CairoShippingCartFactory : IShoppingCartFactory
{
    public IDiscountService CreateDiscount()
    {
        return new RecentClothesDiscount();
    }

    public IShippingCostService CreateShippingCost()
    {
        return new CairoShipingCostService();
    }
}

/// <summary>
/// 
/// Concrete Factory
/// </summary>
public class  AlexShippingCartFactory : IShoppingCartFactory
{
    public IDiscountService CreateDiscount()
    {
        return new RecentClothesDiscount();
    }

    public IShippingCostService CreateShippingCost()
    {
        return new AlexShipingCostService();
    }
}

/// <summary>
/// Client Cart 
/// </summary>
public class Cart
{
    private readonly IDiscountService discountPercentage;
    private readonly IShippingCostService ShippingCost;
    private readonly int Itemcost;
    public Cart(IShoppingCartFactory factory)
    {
        discountPercentage = factory.CreateDiscount();
        ShippingCost = factory.CreateShippingCost();
        Itemcost = 200;
    }

    public void CalCulateCost()
    {
    
        Console.WriteLine($"Total Cost = "+$"{Itemcost-(Itemcost/100* discountPercentage.DiscountPercentage)+ShippingCost.ShippingCost}");
    }

}