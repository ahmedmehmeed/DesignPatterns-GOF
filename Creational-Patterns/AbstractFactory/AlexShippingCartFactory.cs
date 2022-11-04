
/// <summary>
/// Abstract Factory
/// </summary>

/// <summary>
/// Abstract Product
/// </summary>

/// <summary>
/// Abstract Product
/// </summary>

/// <summary>
/// Concrete Product
/// </summary>


/// <summary>
/// Concrete Product
/// </summary>

/// <summary>
/// Concrete Product
/// </summary>

/// <summary>
/// Concrete Product
/// </summary>

/// <summary>
/// 
/// Concrete Factory
/// </summary>
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
