public class MallardDuck : Duck
{
    public override void Display()
    {
        Console.WriteLine("이 오리는 청동오리입니다.");
    }

    public MallardDuck()
    {
        quackBehavior = new QuackNormal();
        flyBehavior = new FlyWithWings();
    }
}
