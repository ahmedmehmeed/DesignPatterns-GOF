

public class CityFromExternal
{
 
    public CityFromExternal(int id, string name, string nickname, int inhabitants)
    {
        Id = id;
        Name = name;
        Nickname = nickname;
        Inhabitants = inhabitants;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Nickname { get; set; }
    public int Inhabitants { get; set; }


}

