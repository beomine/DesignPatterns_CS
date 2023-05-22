// See https://aka.ms/new-console-template for more information


public abstract class CondimentDecorator : Beverage
{
    internal Beverage _beverage = null!;
    public abstract override string GetDescription();
}

