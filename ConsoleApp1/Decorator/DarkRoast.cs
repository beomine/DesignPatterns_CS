﻿// See https://aka.ms/new-console-template for more information


public class DarkRoast : Beverage
{
    public DarkRoast()
    {
        Description = "DarkRoast 커피";
    }

    public override double Cost()
    {
        return 0.99;
    }
}

