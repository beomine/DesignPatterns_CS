namespace ConsoleApp1.Decorator;

internal class Decorator
{
    private static readonly Lazy<Decorator> lazy = new(() => new Decorator());
    public static Decorator Instance
    {
        get
        {
            return lazy.Value;
        }
    }

    private Decorator()
    {

    }

    public void Perform()
    {
        Beverage beverage1 = new Espresso();

        beverage1.BevSize = Beverage.Size.GRANDE;

        print(beverage1);

        beverage1 = new Mocha(beverage1);
        print(beverage1);

        beverage1 = new Whip(beverage1);
        print(beverage1);

        void print(Beverage beverage)
        {
            var cost = beverage.Cost();
            var description = beverage.GetDescription();
            Console.WriteLine(description);
            Console.WriteLine(cost);
        }
    }
}
