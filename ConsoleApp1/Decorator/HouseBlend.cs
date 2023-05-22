// See https://aka.ms/new-console-template for more information


public class HouseBlend : Beverage
{
    public HouseBlend()
    {
        Description = "하우스 블랜드 커피";
    }

    public override double Cost()
    {
        return 0.89;
    }
}

