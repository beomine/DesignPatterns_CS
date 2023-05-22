public class Espresso : Beverage
{
    public Espresso()
    {
        Description = "에스프레소";
    }

    public override double Cost()
    {
        return base.Cost()+ 1.99;
    }

}

