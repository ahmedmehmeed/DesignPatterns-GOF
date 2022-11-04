

var AlexShippingCartFactory = new AlexShippingCartFactory();
var AlexShiping = new Cart(AlexShippingCartFactory);
AlexShiping.CalCulateCost();


var CairoShippingCartFactory = new CairoShippingCartFactory();
var CairoShiping = new Cart(CairoShippingCartFactory);
CairoShiping.CalCulateCost();

Console.ReadLine();
