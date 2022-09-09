
Garage garage = new Garage();

Mercedes mercedes = new Mercedes();
Toyota toyota = new Toyota();


garage.Build(mercedes);
garage.Test();



garage.Build(toyota);
garage.Test();

Console.ReadKey();