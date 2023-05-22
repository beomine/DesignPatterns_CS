public class Mocha : CondimentDecorator
{
    public Mocha(Beverage beverage)
    {
        _beverage = beverage;
    }

    public override double Cost()
    {
        return _beverage.Cost() + 0.20;
    }

    public override string GetDescription()
    {
        return _beverage.GetDescription() + ", 모카";
    }
}

