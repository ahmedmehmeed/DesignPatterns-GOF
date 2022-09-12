
public class address
{
    public string? region { get; set; }
    public string? city { get; set; }
    public string? country { get; set; }

}

/// <summary>
/// Abstract class
/// </summary>
public abstract class ClientPrototype
{
    public int id { get; set; }
    public string? name { get; set; }
    public string? email { get; set; }
    public address? address { get; set; }

    public abstract ClientPrototype ShallowCopy();
    public abstract ClientPrototype DeepCopy();

    public override string ToString()
    {
        return $"Id: {this.id} name: {this.name} address: {this.address.region} {this.address.city} {this.address.country}";
    }

}

/// <summary>
/// Concrete Class
/// </summary>
public class RegularClient : ClientPrototype
{

    public override ClientPrototype ShallowCopy()
    {
        return (ClientPrototype)this.MemberwiseClone();
    }

    public override ClientPrototype DeepCopy()
    {
        ClientPrototype RegularClient = new RegularClient();
        RegularClient = (ClientPrototype)this.MemberwiseClone();
        RegularClient.address =new address
        {
            region=address.region,
            city=address.city,
            country=address.country
        };

        return RegularClient;
    }

}

/// <summary>
/// Concrete Class
/// </summary>
public class ProspectClient : ClientPrototype
{

    public override ClientPrototype ShallowCopy()
    {
        return (ClientPrototype)this.MemberwiseClone();
    }

    public override ClientPrototype DeepCopy()
    {
        ClientPrototype ProspectClient = new RegularClient();
        ProspectClient = (ClientPrototype)this.MemberwiseClone();
        ProspectClient.address = new address
        {
            region = address.region,
            city = address.city,
            country = address.country
        };

        return ProspectClient;
    }

}



