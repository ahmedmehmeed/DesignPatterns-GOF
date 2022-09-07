

public class logger
{
    private logger()
    {

    }
    private static readonly Lazy<logger> lazyLogger = new Lazy<logger>(() => new logger());
    public static logger Instance {
        get
        {
            return lazyLogger.Value;
        }
    } 

    public void log()
    {
        Console.WriteLine("test");
    }

}



