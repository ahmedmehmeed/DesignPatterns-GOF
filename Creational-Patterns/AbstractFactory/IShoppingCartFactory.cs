
/// <summary>
/// Abstract Factory
/// </summary>
public interface IShoppingCartFactory
{
    IDiscountService CreateDiscount();
    IShippingCostService CreateShippingCost();

}
