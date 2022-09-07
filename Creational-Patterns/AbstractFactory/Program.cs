
/// <summary>
/// Abstract Factory
/// </summary>
public interface IShoppingCartFactory
{
    IDiscountService CreateDiscount();
    IShoppingCostService CreateShoppingCost();

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
public interface IShoppingCostService
{
    int ShoppingCost { get; }

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
public class AlexShopingCostService : IShoppingCostService
{
    public int ShoppingCost => 500;
}

/// <summary>
/// Concrete Product
/// </summary>
public class CairoShopingCostService : IShoppingCostService
{
    public int ShoppingCost => 100;
}

/// <summary>
/// 
/// Concrete Factory
/// </summary>
public class CairoShoppingCartFactory : IShoppingCartFactory
{
    public IDiscountService CreateDiscount()
    {
        return new RecentClothesDiscount();
    }

    public IShoppingCostService CreateShoppingCost()
    {
        return new CairoShopingCostService();
    }
}

/// <summary>
/// 
/// Concrete Factory
/// </summary>
public class  AlexShoppingCartFactory : IShoppingCartFactory
{
    public IDiscountService CreateDiscount()
    {
        return new RecentClothesDiscount();
    }

    public IShoppingCostService CreateShoppingCost()
    {
        return new AlexShopingCostService();
    }
}

/// <summary>
/// Client Cart 
/// </summary>
public class Cart
{
    private readonly IDiscountService discountPercentage;
    private readonly IShoppingCostService ShoppingCost;
    private readonly int Itemcost;
    public Cart(IShoppingCartFactory factory)
    {
        discountPercentage = factory.CreateDiscount();
        ShoppingCost = factory.CreateShoppingCost();
        Itemcost = 200;
    }

    public void CalCulateCost()
    {
    
        Console.WriteLine($"Total Cost = "+$"{Itemcost-(Itemcost/100* discountPercentage.DiscountPercentage)+ShoppingCost.ShoppingCost}");
    }

}