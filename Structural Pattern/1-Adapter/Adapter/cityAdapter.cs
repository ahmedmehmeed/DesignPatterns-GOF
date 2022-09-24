

public class cityAdapter : IcityAdapter
{
    CityFromExternal cityFromExternal = new CityFromExternal(1, "Cairo", "Capital", 50000000);

    public city GetCity()
    {
        city citymapping = new city()
        {

            Fullname =cityFromExternal.Name+cityFromExternal.Nickname,
            Inhabitants=cityFromExternal.Inhabitants
            
        };
        return citymapping;


    }

    public void ToString(city city)
    {
       Console.WriteLine($"{city.Fullname} {city.Inhabitants}") ;
    }
}

