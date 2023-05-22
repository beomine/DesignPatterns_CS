public class Milk : CondimentDecorator
{
    public Milk(Beverage beverage)
    {
        _beverage = beverage;
    }

    public override double Cost()
    {
        return _beverage.Cost() + 0.10;
    }

    public override string GetDescription()
    {
        return _beverage.GetDescription() + ", 우유";
    }
}

