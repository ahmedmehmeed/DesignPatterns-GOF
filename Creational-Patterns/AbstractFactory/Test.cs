

var AlexShoppingCartFactory = new AlexShoppingCartFactory();
var AlexShoping = new Cart(AlexShoppingCartFactory);
AlexShoping.CalCulateCost();


var CairoShoppingCartFactory = new CairoShoppingCartFactory();
var CairoShoping = new Cart(CairoShoppingCartFactory);
CairoShoping.CalCulateCost();

Console.ReadLine();