
ClientPrototype ClientPrototype = new RegularClient
{
    id=1,
    name="ahmed",
    address=new address
    {
        region="Nasr City",
        city="Cairo",
        country="Egypt"
    }
};

ClientPrototype ClientPrototype1 = ClientPrototype.DeepCopy();
Console.WriteLine("************** Original Object ************");
Console.WriteLine(ClientPrototype.ToString());

Console.WriteLine("************** DeepCopy Object ************");
Console.WriteLine(ClientPrototype1.ToString());

Console.WriteLine("%%%%%%%%% After Change %%%%%%%%%%%%");

ClientPrototype ClientPrototype2 = ClientPrototype.DeepCopy();
ClientPrototype2.address.city = "Alex";
ClientPrototype2.id = 3;
Console.WriteLine("************** Original Object ************");
Console.WriteLine(ClientPrototype.ToString());

Console.WriteLine("************** DeepCopy Object ************");
Console.WriteLine(ClientPrototype2.ToString());



ClientPrototype ClientPrototype3 = ClientPrototype.ShallowCopy();
ClientPrototype3.address.city = "Alex";
ClientPrototype3.id = 3;
Console.WriteLine("************** Original Object ************");
Console.WriteLine(ClientPrototype.ToString());

Console.WriteLine("************** shallowCopy Object ************");
Console.WriteLine(ClientPrototype3.ToString());



Console.ReadKey();