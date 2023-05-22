public class Decaf : Beverage
{
    public Decaf()
    {
        Description = "Decaf 커피";
    }

    public override double Cost()
    {
        return 1.05;
    }
}

