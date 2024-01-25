public class Car: Vehicle, IAccelerate
{
    private int speed;
    public Car(int speed)
    {
        speed = speed;
    }

    public int Speed
    {
        get { return speed; }
        set 
        {  
            if (value > 500)
            {
                speed = 500;
            }
            else
            {
                speed = value;
            }
        }
    }

    public void applyAccelerator()
    {
        Console.WriteLine("Car speed will increase");
    }
}
