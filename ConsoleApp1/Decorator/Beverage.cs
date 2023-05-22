public abstract class Beverage
{
    public string Description = string.Empty;
    public enum Size { TALL, GRANDE,VENTI}
    public Size BevSize { get; set; } = Size.TALL;

    public virtual string GetDescription()
    {
        return Description;
    }

    public virtual double Cost()
    {
        double cost = 0;

        switch (BevSize)
        {
            case Size.TALL:
                cost = 0;
                break;
            case Size.GRANDE:
                cost = 0.15;
                break;
            case Size.VENTI:
                cost = 0.2;
                break;
            
            default:
                break;
        }
        return cost;
    }
}

