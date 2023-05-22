public class ModelDuck : Duck
{
    public override void Display()
    {
        Console.WriteLine("저는 모형 오리입니다.");
    }

    public ModelDuck()
    {
        flyBehavior = new FlyNoWay();
        quackBehavior = new QuackNormal();
    }
}
