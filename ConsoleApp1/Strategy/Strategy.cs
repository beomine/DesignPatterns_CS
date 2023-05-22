namespace ConsoleApp1.Strategy;

internal class Strategy
{
    private static readonly Lazy<Strategy> lazy = new(() => new Strategy());
    public static Strategy Instance
    {
        get
        {
            return lazy.Value;
        }
    }

    private Strategy()
    {

    }

    public void Perform()
    {

    }
}
