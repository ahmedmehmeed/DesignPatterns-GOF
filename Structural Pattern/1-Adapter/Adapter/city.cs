

public class city
{
    public city()
    {

    }
    public city(string fullname, long inhabitants)
    {
        Fullname = fullname;
        Inhabitants = inhabitants;
    }

    public string Fullname { get; set; }
    public long Inhabitants { get; set; }
}

