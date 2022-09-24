

using System.Text;
/// <summary>
/// Product
/// </summary>
public class car
{
    private  readonly List<string> _parts;
    private readonly string _carType;

    public car(string type)
    {
        _carType = type;
        _parts = new();
    }

    public void AddParts(string part)
    {
        _parts.Add(part);
    }
         


    public override string ToString()
    {
        var ST = new StringBuilder();

        foreach (var part in _parts)
        {
            ST.Append($"Car of {_carType} has part of {part}\n ");
        }

        return ST.ToString();
    }

}