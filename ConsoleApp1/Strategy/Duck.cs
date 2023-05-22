public abstract class Duck
{
    internal IFlyBehavior flyBehavior = null!;
    internal IQuackBehavior quackBehavior = null!;
    public void Swim()
    {
        Console.WriteLine("SWIM");
    }

    public abstract void Display();

    public void PerformQuack()
    {
        quackBehavior.Quack();
    }

    public void PerformFly()
    {
        flyBehavior.Fly();
    }

    public void SetQuackBehavior(IQuackBehavior qb)
    {
        quackBehavior = qb;
    }

    public void SetFlyBehavior(IFlyBehavior fb)
    {
        flyBehavior = fb;
    }
}
