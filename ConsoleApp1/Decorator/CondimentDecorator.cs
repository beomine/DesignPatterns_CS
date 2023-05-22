public abstract class CondimentDecorator : Beverage
{
    internal Beverage _beverage = null!;
    public abstract override string GetDescription();
}

