




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