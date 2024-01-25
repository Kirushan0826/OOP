class Jeep: Vehicle, IBreak, IAccelerate
{
    public override void go()
    {
        Console.WriteLine("The jeep is moving");
    }

    public void applyBreak()
    {
        Console.WriteLine("The jeep will stop");
    }
    public void applyAccelerator()
    {
        Console.WriteLine("The jeep will increase the speed");
    }
}