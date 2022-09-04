/// <summary>
/// inaccessable
/// </summary>
//logger logger = new logger();

logger instance1 = logger.Instance;
logger instance2 = logger.Instance;
if (instance1 == instance2 && instance2 == logger.Instance)
{
    Console.WriteLine("Instances are the same");
}

