public class Soy : CondimentDecorator
{
    public Soy(Beverage beverage)
    {
        _beverage = beverage;
    }

    public override double Cost()
    {
        return _beverage.Cost() + 0.15;
    }

    public override string GetDescription()
    {
        return _beverage.GetDescription() + ", 두유";
    }
}

