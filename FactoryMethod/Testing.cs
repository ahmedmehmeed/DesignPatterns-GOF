  
var Shipping = new List<ShippingService>
  {
      new Landshipping(),new Airshipping()
  };

foreach(var S in Shipping)
{
    var shippingCost = S.getShippingPercentage;
    Console.WriteLine($"Percentage {shippingCost} from {S.ToString()} ");

}

Console.ReadKey();