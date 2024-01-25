public abstract class Vehicle
{
    public int initialSpeed = 0;
    public void readyGo() 
    { 
        Console.WriteLine("The vehicle is start moving in " + initialSpeed);
    }
    public virtual void go()
    {
        
    }
}
