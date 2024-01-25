public class Bicycle : Vehicle, IBreak
{
    public int wheels = 2;
    public override void go()
    {
        Console.WriteLine("The bicycle is moving");
    }

    public void applyBreak()
    {
        Console.WriteLine("The bicycle will stop on the spot");
    }
}
