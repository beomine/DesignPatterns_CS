public class Whip : CondimentDecorator
{
    public Whip(Beverage beverage)
    {
        _beverage = beverage;
    }

    public override double Cost()
    {
        return _beverage.Cost() + 0.12;
    }

    public override string GetDescription()
    {
        return _beverage.GetDescription() + ", 휘핑크림";
    }
}

